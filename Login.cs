using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibrarySystem
{
    public partial class LoginForm : Form
    {
        string username;
        string password;

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            //点击Login时触发
            var values = new Dictionary<string, string>
            {
                {"username", username},
                {"password", password},
            };
            Dictionary<string, string> result = await PublicOperations.NetWork("login", values);

            if (result["status"] == "True")
            {
                HomePage homePage = new HomePage();
                PublicOperations.OpenForm(this, homePage);
            }
            else
            {
                MessageBox.Show("Wrong Password!", "Login Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }


        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {
            username = UserNameText.Text;

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            password = PasswordText.Text;

        }
    }


}
