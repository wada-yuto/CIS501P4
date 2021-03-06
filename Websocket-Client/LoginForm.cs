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
    public delegate IUser CheckDatabaseDel(string username, string password);
    public delegate User AddToContactDel(string username);
    public delegate void UpdateContactListDel(IUser user);
    public delegate User RemoveContactDel(string user);
    public delegate void LogoutDel(IUser user);
    public delegate void NameDel(User u);
    public partial class LoginForm : Form
    {
        //Need to check the database for the username -> Open the contact form
        //Probably need delegates to call ChatController stuff and Database stuff

        private string username;
        private string password;

        private CheckDatabaseDel CheckDatabaseDelegate;
        private AddToContactDel AddToContactDelegate;
        private UpdateContactListDel UpdateContactListDelegate;
        private RemoveContactDel RemoveContactDelegate;
        private LogoutDel LogoutDelegate;
        private NameDel NameDelegate;

        private ChatForm form;

        public LoginForm(ChatForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void SetUp(CheckDatabaseDel CheckDatabaseDelegate, AddToContactDel AddToContactDelegate, 
            UpdateContactListDel UpdateContactListDelegate, RemoveContactDel RemoveContactDelegate,
            LogoutDel LogoutDelegate, NameDel NameDelegate)
        {
            this.CheckDatabaseDelegate = CheckDatabaseDelegate;
            this.AddToContactDelegate = AddToContactDelegate;
            this.UpdateContactListDelegate = UpdateContactListDelegate;
            this.RemoveContactDelegate = RemoveContactDelegate;
            this.LogoutDelegate = LogoutDelegate;
            this.NameDelegate = NameDelegate;
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
            User user = (User)CheckDatabaseDelegate(username, password);
            
            ContactForm contactForm = new ContactForm(user,form,AddToContactDelegate,UpdateContactListDelegate,
            RemoveContactDelegate,LogoutDelegate);
            NameDelegate(user);
            contactForm.Show();


            //Check in the Database to see if that user exist (delegate)
            //Call CheckDatabase(username, password) (delegate from ChatController)
            //If it exist, bring up the contact form, makign the contact form should belong in the ChatController
            //If not, make new user, this should be handled in the login logic in the database.
        }
    }
}
