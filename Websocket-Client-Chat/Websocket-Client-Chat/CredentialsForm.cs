using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Websocket_Client_Chat
{
    public partial class uxCredentialsForm : Form
    {
        public uxCredentialsForm()
        {
            InitializeComponent();
        }

        private void CredentialsForm_Load(object sender, EventArgs e)
        {

        }

        private string GetPassword()
        {
            return uxPasswordInput.Text;
        }

        private string GetUsername()
        {
            return uxUsernameInput.Text;
        }

        private void uxLogin_Click(object sender, EventArgs e)
        {
            foreach (User u in allUsers)
            {
                if (u.Username == GetUsername())
                {
                    Login(u);
                    return;
                }
            }
            
            User u = new User();
            u.Username = GetUsername();
            u.Password = GetPassword();
            u.Status = "Online";
            allUsers.Add(u);
            Login(u);

        }

        private void Login(User u)
        {

        }
    }
}
