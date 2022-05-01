using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Chat_Library
{
    public class User : IUser
    {
        private string _username;
        private string _password;
        private string _status;
        private BindingList<IUser> _contacts = new BindingList<IUser>();
        private int _id;

        public string UserName
        {
            get { return _username; }
            set { _username = value; }

        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public BindingList<IUser> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }


        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public int ServerID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string GetUsername()
        {
            return this.UserName;
        }

        public string GetPassword()
        {
            return this.Password;
        }

        public string GetStatus()
        {
            return this.Status;
        }

        public int GetServerID()
        {
            return this.ServerID;
        }


        public BindingList<IUser> GetContactList()
        {
            return this.Contacts;
        }

        public User(string username, string password)
        {
            this._username = username;
            this.Password = password;
            this.Status = "Online";
        }

        public override string ToString()
        {
            return UserName;
        }

    }
}
