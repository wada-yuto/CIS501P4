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
        private List<User> _contacts = new List<User>();
        private string _id;

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

        public List<User> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }


        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string ServerID
        {
            get { return _id; }
            set { _id = value; }
        }


        public List<User> GetContactList()
        {
            return this.Contacts;
        }

        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
            this.Status = "Online";
        }

        public override string ToString()
        {
            return UserName;
        }

        public void AddContact(object user)
        {
            throw new NotImplementedException();
        }

        public void RemoveContact(object user)
        {
            throw new NotImplementedException();
        }

        List<IUser> IUser.GetContactList()
        {
            throw new NotImplementedException();
        }
    }
}
