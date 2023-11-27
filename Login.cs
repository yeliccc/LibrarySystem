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
    public partial class LoginForm : Form
    {
        public PublicOperations publicOperations = new PublicOperations(); // 包含一些公用操作以节省代码
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体加载时触发
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //点击Login时触发
            HomePage homePage = new HomePage();
            publicOperations.OpenForm(this, homePage); //注意，本程序使用Hide，其他时候应该close以节省内存

        }
    }

    public class PublicOperations
    {
        public void OpenForm(Form currentForm, Form newForm)
        {
            //打开其他窗口
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
            currentForm.Hide();
        }
    }
}
