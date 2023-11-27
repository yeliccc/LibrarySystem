using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class HomePage : Form
    {
        public PublicOperations publicOperations = new PublicOperations(); // 包含一些公用操作以节省代码
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomPage_Load(object sender, EventArgs e)
        {

        }

        private void searchBox1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            publicOperations.OpenForm(this, borrow);
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
