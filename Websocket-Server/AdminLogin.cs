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
using WebSocketSharp.Server;

namespace Websocket_Server
{
   
    public partial class AdminLogin : Form
    {
        private string username;
        private string password;
        private Database database = new Database();
        private bool serverstatus = false;

        private WebSocketServer wss;
        public AdminLogin()
        {
            //Server serv = new Server();
            //AdminPanel adminPanel = new AdminPanel();
            //serv.SetUp(adminPanel.UpdateOnlineUserList);
            
            ////hard coded admin
            database.AdminUsers.Add(new User("admin", "password"));

            //wss = new WebSocketServer(8001);

            //// Add the Echo websocket service
            //wss.AddWebSocketService<Echo>("/echo");

            //// Add the Chat websocket service
            //wss.AddWebSocketService<Server>("/chat");

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
                if (user.UserName.Equals(username))
                {
                    if (user.Password.Equals(password))
                    {
                        //wss.Start();
                        //Console.WriteLine("Server started on port " + wss.Port);
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
            wss.Stop();
        }
    }
}
