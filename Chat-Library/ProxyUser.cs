using Chat_Library;
using System.Collections.Generic;
using System.ComponentModel;

namespace Websocket_Client_Chat
{
    public class ProxyUser : IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string ServerID { get; set; }

        public User remoteUser { get; set; }

        public ProxyUser()
        {

        }

        public ProxyUser(User user, string username, string password)
        {
            UserName = username;
            Password = password;
            remoteUser = user;
            if(user.ServerID != null)
            {
                this.ServerID = user.ServerID;
            }
            this.ServerID = user.ServerID;
        }

        public void AddContact(object user)
        {
            if (user is User u)
            {
                remoteUser.AddContact(u);
            }
        }

        public void RemoveContact(object user)
        {
            if (user is User u && remoteUser.Contacts.Contains(u))
            {
                remoteUser.Contacts.Remove(u);
            }
        }

        public List<User> GetAccounts()
        {
            return remoteUser.Contacts;
        }

        public List<IUser> GetContactList()
        {
            List<IUser> contacts = new List<IUser>();
            foreach(User u in this.GetAccounts())
            {
                contacts.Add(u);
            }
            return contacts;
        }

        
    }
}