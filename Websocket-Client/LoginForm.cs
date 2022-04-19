using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Websocket_Client
{
    public partial class LoginForm : Form
    {
        //Need to check the database for the username -> Open the contact form
        //Probably need delegates to call ChatController stuff and Database stuff

        string username;
        string password;

        public LoginForm()
        {
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

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            username = GetUsername();
            password = GetPassword();
           
            //Check in the Database to see if that user exist (delegate)
            //If it exist, bring up the contact form, makign the contact form should belong in the ChatController
            //If not, make new user, this should be handled in the login logic in the database.
        }
    }
}
