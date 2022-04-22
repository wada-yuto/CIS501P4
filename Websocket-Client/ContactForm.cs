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

namespace Websocket_Client
{
    
    public partial class ContactForm : Form
    {
        private User user;
        private AddToContactDel AddToContactDelegate;
        private string username;
        private ChatForm form;
        public ContactForm(User user, ChatForm chatform, AddToContactDel AddToContactDelegate)
        {
            this.user = user;
            InitializeComponent();
            uxFriendListLabel.Text = user.UserName + "'s Friend List";
            //SetUp Method
            this.AddToContactDelegate = AddToContactDelegate;
            form = chatform;
        }
        /// <summary>
        /// Return textbox content
        /// </summary>
        /// <returns>Return textbox content</returns>
        private string GetFriendName()
        {
            return uxAddContactUsernameTextBox.Text;
        }


        private void uxAddFriendButton_Click(object sender, EventArgs e)
        {
            //Get username that they want to add
            username = GetFriendName();
            //Check to see if this return null, if not null, add to the contact list
            IUser user = AddToContactDelegate(username);
            if (user == null)
            {
                MessageBox.Show("This user does not exist");
                uxAddContactUsernameTextBox.Clear();
            }
            else
            {
                this.user.Contacts.Add(user);
                MessageBox.Show("This user has been added to your contact");
            }
            //Ping Server for change
        }

        private void uxStartChatButton_Click(object sender, EventArgs e)
        {
            form.Show();
        }
    }
}
