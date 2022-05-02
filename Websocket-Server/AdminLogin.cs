using Chat_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Websocket_Server
{
    public partial class AdminLogin : Form
    {
        private string username;
        private string password;
        private Database database = new Database();
        public AdminLogin()
        {
            //hard coded admin
            database.AdminUsers.Add(new User("admin", "password"));
            InitializeComponent();
        }

        private string GetUsername()
        {
            return uxUsernameTextBox.Text;
        }

        private string GetPassword()
        {
            return uxPasswordTextBox.Text;
        }

        

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            username = GetUsername();
            password = GetPassword();
            foreach (IUser user in database.AdminUsers)
            {
                if (user.GetUsername().Equals(username))
                {
                    if (user.GetPassword().Equals(password))
                    {
                        new AdminPanel().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("Username not found");
                }
            }
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
