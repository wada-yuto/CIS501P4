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
        private UpdateContactListDel UpdateContactDelegate;
        private RemoveContactDel RemoveContactDelegate;
        private LogoutDel LogoutDelegate;
        private string username;
        private ChatForm form;
        public ContactForm(User user, ChatForm chatform, AddToContactDel AddToContactDelegate, UpdateContactListDel UpdateContactDelegate, 
            RemoveContactDel RemoveContactDelegate, LogoutDel LogoutDelegate)
        {
            this.user = user;
            InitializeComponent();
            uxFriendListLabel.Text = user.UserName + "'s Friend List";
            //SetUp Method
            this.AddToContactDelegate = AddToContactDelegate;
            this.UpdateContactDelegate = UpdateContactDelegate;
            this.RemoveContactDelegate = RemoveContactDelegate;
            this.LogoutDelegate = LogoutDelegate;
            uxFriendListListBox.DataSource = null;
            uxFriendListListBox.DataSource = user.Contacts;
            
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
            User user = AddToContactDelegate(username);
            if (user == null)
            {
                MessageBox.Show("This user does not exist");
                uxAddContactUsernameTextBox.Clear();
            }
            else
            {
                MessageBox.Show(user.Contacts.Count.ToString());
                this.user.Contacts.Add(user);
                MessageBox.Show(user.Contacts.Count.ToString());
                MessageBox.Show("This user has been added to your contact");
            }
            UpdateContactDelegate(this.user);
            uxFriendListListBox.DataSource = null;
            uxFriendListListBox.DataSource = this.user.Contacts;

            //Ping Server for change
        }

        private void uxStartChatButton_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void uxStartChatting_Click(object sender, EventArgs e)
        {

        }

        private void uxRemoveFriendButton_Click(object sender, EventArgs e)
        {
            //Get username that they want to add
            string SelectedUser = uxFriendListListBox.SelectedItem.ToString();
            //Check to see if this return null, if not null, add to the contact list
            User userToRemove = RemoveContactDelegate(SelectedUser);
            if (userToRemove == null)
            {
                MessageBox.Show("This user does not exist");
                uxAddContactUsernameTextBox.Clear();
            }
            else
            {
                //MessageBox.Show(user.Contacts.Count.ToString());
                //this.user.Contacts.Remove(userToRemove);
                //foreach(User currentUser in this.user.Contacts)
                //{
                //    if (currentUser.UserName == userToRemove.UserName)
                //    {
                //        this.user.Contacts.Remove(currentUser);
                //    }
                //    continue;
                //}

                for(int i = 0; i < this.user.Contacts.Count; i++)
                {
                    if(this.user.Contacts[i].UserName == userToRemove.UserName)
                    {
                        this.user.Contacts.Remove(this.user.Contacts[i]);
                    }
                    continue;
                }
                MessageBox.Show(user.Contacts.Count.ToString());
                
                MessageBox.Show("This user has been removed from your contact list");
            }
            UpdateContactDelegate(this.user);
            uxFriendListListBox.DataSource = null;
            uxFriendListListBox.DataSource = this.user.Contacts;

            //Ping Server for change
        }

        private void uxLogoutButton_Click(object sender, EventArgs e)
        {
            IUser logoutUser = this.user;
            LogoutDelegate(logoutUser);
            this.Close();
        }
    }
}
