using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Library
{
    public class User :IUser
    {
        private string _username;
        private string _password;
        private string _status;
        private List<User> _contacts;

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
    }
}
