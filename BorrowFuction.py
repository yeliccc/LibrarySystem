from flask import Flask, request, jsonify
import pymysql
from datetime import datetime, timedelta

app = Flask(__name__)

def connect_db():
    return pymysql.connect(host='localhost', user="root", password="", db="")


@app.route("/find_book", methods=["Post"])
def find_book():
    keyword = request.form.get("book_name")
    category = request.form.get("category")
    page = int(request.form.get("page", 1))
    per_page = int(request.form.get("per_page", 5)) #分页功能, page当前页, per_page每页数目默认值为5, 可以不提供page与per_page使用默认值
    offset = (page - 1) * per_page
    with connect_db() as db:
        with db.cursor() as cursor:
            if keyword and category:
                cursor.execute('SELECT Title, Author, Publisher, ISBN, Price, Description FROM book WHERE title LIKE %s AND category = %s LIMIT %s OFFSET %s', ('%' + keyword + '%', category, per_page, offset))
            elif keyword:
                cursor.execute('SELECT Title, Author, Publisher, ISBN, Price, Description FROM book WHERE title LIKE %s LIMIT %s OFFSET %s', ('%' + keyword + '%', per_page, offset))
            elif category:
                cursor.execute('SELECT Title, Author, Publisher, ISBN, Price, Description FROM book WHERE category = %s LIMIT %s OFFSET %s', (category, per_page, offset))
            else:
                return jsonify(status=False, reason="Missing keyword or category")
            results = cursor.fetchall()
    return jsonify(results=results)

@app.route("/borrow", methods=["POST"])
def borrow():
    user_id = request.form.get("user_id")
    book_id = request.form.get("book_id")
    try:
        db = connect_db()
        cursor = db.cursor()
        cursor.execute('START TRANSACTION')
    
        # Check if the book is available
        cursor.execute("SELECT Status FROM book WHERE book_id = %s FOR UPDATE", (book_id,))
        Status = cursor.fetchone()[0]
        if not Status:
            db.rollback()
            return jsonify(status=False, reason="The book is not available")
    
        #Check if the user has reached the borrow limit
        cursor.execute("SELECT COUNT(*) FROM BorrowRecord WHERE user_id = %s FOR UPDATE", (user_id,))
        borrow_count = cursor.fetchone()[0]
        cursor.execute("SELECT Limit FROM BorrowLimit WHERE user_id = %s FOR UPDATE", (user_id,))
        borrow_limit = cursor.fetchone()[0]
        if borrow_count >= borrow_limit:
            db.rollback()
            return {"status": False, "reason": "You have reached the borrow limit"}
    
        #If not, check if the book is available
        borrow_date = datetime.now()
        cursor.execute('INSERT INTO BookRecord (user_id, book_id, BorrowDate) VALUES (%s, %s, %s)', (user_id, book_id, borrow_date))
        db.commit()
        return {"status": True, "reason": "You have borrowed this book"}
    except Exception as e:
        db.rollback()
        return {"status": False, "reason": str(e)}
    finally:
        db.close()

@app.route("/return_book", methods=["POST"])
def return_book():
    user_id = request.form.get("user_id")
    book_id = request.form.get("book_id")
    return_date = datetime.now()
    db = connect_db()
    cursor = db.cursor()
    
    # Check if the book is borrowed by the user
    cursor.execute("SELECT COUNT(*) FROM bookborrow WHERE user_id = %s AND book_id = %s", (user_id, book_id))
    if cursor.fetchone()[0] == 0:
        return {"status": False}

    # Get the borrow date and the book price
    cursor.execute('SELECT BorrowDate, price FROM bookborrow JOIN book ON bookborrow.book_id = book.book_id WHERE user_id = %s AND book_id = %s', (user_id, book_id))
    borrow_date, book_price = cursor.fetchone()

    # Calculate the fine 七天之内还书不罚款，超过七天赔偿书本费
    if return_date > borrow_date + timedelta(days=7):
        fine_amount = book_price
    else:
        fine_amount = 0

    cursor.execute('UPDATE bookborrow SET ReturnDate = %s, FineAmount = %s WHERE user_id = %s AND book_id = %s', (return_date, fine_amount, user_id, book_id))
    cursor.execute('UPDATE book SET Status = True WHERE book_id = %s', (book_id,))
    db.commit()
    db.close()
    return {"status": True}

