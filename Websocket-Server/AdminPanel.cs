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
        
        public AdminPanel()
        {
            // dummy users to test admin panel is adding them to correct listbox
            IUser v = new User("User1", "password1");
            database.UserList.Add(v);
            v = new User("USer2", "password2");
            database.UserList.Add(v);

            InitializeComponent();

            // updates the listboxes of all users in the database
            UpdateUserList(database.UserList);
        }


        /// <summary>
        /// Gets all the users in the database and updates the list boxes
        /// depending on the status of the users
        /// </summary>
        /// <param name="activeUsers">List of all users in the database</param>
        public void UpdateUserList(List<IUser> activeUsers)
        {
            foreach(IUser user in activeUsers)
            {
                if(user.GetStatus().Equals("Online"))
                {
                    uxOnlineUsersListBox.Items.Add(user.GetUsername());
                    uxAllUsersListBox.Items.Add(user.GetUsername());
                }
                else
                {
                    uxAllUsersListBox.Items.Add(user.GetUsername());
                }
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
