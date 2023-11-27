
namespace LibrarySystem
{
    partial class Borrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerOfHomePage = new System.Windows.Forms.SplitContainer();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.BorrowStatus = new System.Windows.Forms.Label();
            this.BookInfoText = new System.Windows.Forms.TextBox();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.BriefInfo = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BookIDText = new System.Windows.Forms.TextBox();
            this.ExactSearch = new System.Windows.Forms.Label();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.BookInfoList = new System.Windows.Forms.ListBox();
            this.BookDetailInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOfHomePage)).BeginInit();
            this.splitContainerOfHomePage.Panel1.SuspendLayout();
            this.splitContainerOfHomePage.Panel2.SuspendLayout();
            this.splitContainerOfHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerOfHomePage
            // 
            this.splitContainerOfHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerOfHomePage.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOfHomePage.Name = "splitContainerOfHomePage";
            // 
            // splitContainerOfHomePage.Panel1
            // 
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.ReturnButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BorrowStatus);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookInfoText);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BorrowButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BriefInfo);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.SearchButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookIDText);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.ExactSearch);
            this.splitContainerOfHomePage.Panel1.Tag = "";
            // 
            // splitContainerOfHomePage.Panel2
            // 
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.BookCover);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.BookInfoList);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.BookDetailInfo);
            this.splitContainerOfHomePage.Size = new System.Drawing.Size(1665, 761);
            this.splitContainerOfHomePage.SplitterDistance = 552;
            this.splitContainerOfHomePage.TabIndex = 0;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(209, 487);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(153, 42);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "RETURN";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // BorrowStatus
            // 
            this.BorrowStatus.AutoSize = true;
            this.BorrowStatus.Location = new System.Drawing.Point(31, 556);
            this.BorrowStatus.Name = "BorrowStatus";
            this.BorrowStatus.Size = new System.Drawing.Size(161, 36);
            this.BorrowStatus.TabIndex = 6;
            this.BorrowStatus.Text = "BORROW SUCCESS!\r\nFROM 2023 TO 2024";
            // 
            // BookInfoText
            // 
            this.BookInfoText.Location = new System.Drawing.Point(34, 243);
            this.BookInfoText.Multiline = true;
            this.BookInfoText.Name = "BookInfoText";
            this.BookInfoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BookInfoText.Size = new System.Drawing.Size(494, 238);
            this.BookInfoText.TabIndex = 5;
            this.BookInfoText.Text = "Name:\r\nRemain:\r\nStatus:";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Location = new System.Drawing.Point(34, 487);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(155, 42);
            this.BorrowButton.TabIndex = 4;
            this.BorrowButton.Text = "BORROW";
            this.BorrowButton.UseVisualStyleBackColor = true;
            // 
            // BriefInfo
            // 
            this.BriefInfo.AutoSize = true;
            this.BriefInfo.Location = new System.Drawing.Point(31, 207);
            this.BriefInfo.Name = "BriefInfo";
            this.BriefInfo.Size = new System.Drawing.Size(152, 18);
            this.BriefInfo.TabIndex = 3;
            this.BriefInfo.Text = "Book Information";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(34, 145);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(140, 42);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookIDText
            // 
            this.BookIDText.Location = new System.Drawing.Point(34, 83);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(439, 28);
            this.BookIDText.TabIndex = 1;
            // 
            // ExactSearch
            // 
            this.ExactSearch.AutoSize = true;
            this.ExactSearch.Location = new System.Drawing.Point(37, 43);
            this.ExactSearch.Name = "ExactSearch";
            this.ExactSearch.Size = new System.Drawing.Size(107, 18);
            this.ExactSearch.TabIndex = 0;
            this.ExactSearch.Text = "ExactSearch";
            // 
            // BookCover
            // 
            this.BookCover.Image = global::LibrarySystem.Properties.Resources.Coverage;
            this.BookCover.Location = new System.Drawing.Point(440, 93);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(609, 615);
            this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookCover.TabIndex = 2;
            this.BookCover.TabStop = false;
            // 
            // BookInfoList
            // 
            this.BookInfoList.FormattingEnabled = true;
            this.BookInfoList.ItemHeight = 18;
            this.BookInfoList.Items.AddRange(new object[] {
            "Detailed Information1",
            "Detailed Information2"});
            this.BookInfoList.Location = new System.Drawing.Point(31, 93);
            this.BookInfoList.Name = "BookInfoList";
            this.BookInfoList.Size = new System.Drawing.Size(371, 616);
            this.BookInfoList.TabIndex = 1;
            // 
            // BookDetailInfo
            // 
            this.BookDetailInfo.AutoSize = true;
            this.BookDetailInfo.Location = new System.Drawing.Point(39, 43);
            this.BookDetailInfo.Name = "BookDetailInfo";
            this.BookDetailInfo.Size = new System.Drawing.Size(188, 18);
            this.BookDetailInfo.TabIndex = 0;
            this.BookDetailInfo.Text = "Detailed Information";
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 761);
            this.Controls.Add(this.splitContainerOfHomePage);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Borrow_FormClosing);
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.splitContainerOfHomePage.Panel1.ResumeLayout(false);
            this.splitContainerOfHomePage.Panel1.PerformLayout();
            this.splitContainerOfHomePage.Panel2.ResumeLayout(false);
            this.splitContainerOfHomePage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOfHomePage)).EndInit();
            this.splitContainerOfHomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerOfHomePage;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox BookIDText;
        private System.Windows.Forms.Label ExactSearch;
        private System.Windows.Forms.Label BriefInfo;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.TextBox BookInfoText;
        private System.Windows.Forms.Label BorrowStatus;
        private System.Windows.Forms.Label BookDetailInfo;
        private System.Windows.Forms.ListBox BookInfoList;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.PictureBox BookCover;
    }
}