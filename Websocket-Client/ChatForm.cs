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
using Websocket_Client_Chat;
using Message = Websocket_Client_Chat.Message;

namespace Websocket_Client
{
    public partial class ChatForm : Form
    {
        private List<User> _usersInChat;
        public ChatForm(Message newMessageHandler)
        {
            InitializeComponent();

             
            // Add name in the form's title
            // Whenever the Enter key is pressed inside the messageTextBox,
            //   pass the message to newMessageHandler
            //   if successfully handled, clear out the messageTextBox
            uxMessageTextBox.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string message = uxMessageTextBox.Text;
                    if (newMessageHandler(message))
                    {
                        uxMessageTextBox.Text = "";
                    }
                }
            };

            // Make sure to focus on messageTextBox when the form is loaded
            uxMessageTextBox.Select();
        }



        public List<User> UsersInChat
        {
            get { return _usersInChat; }
            set { _usersInChat = value; }
        }

        public void SetName()
        {
            if (UsersInChat != null)
            {
                string allUsers = "";
                foreach (User u in UsersInChat)
                {
                    allUsers += " " + u.UserName;
                }
                Text = "Chat: " + allUsers;
            }
            
        }
        public bool MessageReceived(string message)
        {
            // Add message to messageListBox and scroll to bottom
            // Invoke is used to make sure that this is done in the GUI thread
            Invoke(new Action(() => uxMessageListBox.TopIndex = uxMessageListBox.Items.Add(message)));

            return true;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
