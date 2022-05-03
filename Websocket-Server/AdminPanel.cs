using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat_Library;

namespace Websocket_Server
{
    public partial class AdminPanel : Form
    {
        Database database = new Database();
        List<IUser> users = new List<IUser>();
        public AdminPanel()
        {
            users = database.GetUsersFromFile();
            InitializeComponent();
            // updates the listboxes of all users in the database
            UpdateUserList();
        }


        /// <summary>
        /// Gets all the users in the database and updates the list boxes
        /// depending on the status of the users
        /// </summary>
        /// <param name="activeUsers">List of all users in the database</param>
        public void UpdateUserList()
        {
            // updates the listboxes of all users in the database
            uxAllUsersListBox.DataSource = null;
            uxAllUsersListBox.DataSource = users;

            // updates the list box of all online users
            uxOnlineUsersListBox.DataSource = null;
            uxOnlineUsersListBox.DataSource = database.OnlineUsers;
        }

        public void UpdateOnlineUserList(List<IUser> activeUsers)
        {
            if (uxOnlineUsersListBox.InvokeRequired)
            {
                uxOnlineUsersListBox.Invoke(new MethodInvoker(delegate { uxOnlineUsersListBox.DataSource = activeUsers; }));
            }
            else
            {
                uxOnlineUsersListBox.DataSource = activeUsers;
                uxOnlineUsersListBox.Update();
            }
        }
        public void UpdateChatList(List<IUser> ActiveChats)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}