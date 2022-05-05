using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websocket_Client_Chat;

namespace Chat_Library
{
    public class DatabaseProxy : IDatabase
    {
        /// <summary>
        /// List of all the Online Users
        /// </summary>
        public List<IUser> OnlineUsers { get; set; }

        public IUser proxyUser { get; set; }
        public Database database { get; set; }

        public DatabaseProxy()
        {
            
        }

        public DatabaseProxy(Database databaseproxy)
        {
            OnlineUsers = new List<IUser>();
            database = databaseproxy;
            foreach(User u in databaseproxy.OnlineUsers)
            {
                OnlineUsers.Add((IUser)u);
            }
        }

        public IUser Login(string username, string password)
        {
            IUser user = new ProxyUser();
            proxyUser = database.Login(username, password);
            user = this.proxyUser;
            return user;

        }

        public void Logout(string username)
        {
            if (database == null)
            {
                database = new Database();
            }
            //return database.Login(username);
        }

        public User AddToContact(string username)
        {
            //Need to implement the code

            if (database == null)
            {
                database = new Database();
            }
            return database.AddtoContact(username);
        }

        public void UpdateContact(IUser user)
        {
            if (database == null)
            {
                database = new Database();
            }
            database.UpdateContact(user);
        }

        public User RemoveContact(string username)
        {
            if (database == null)
            {
                database = new Database();
            }
            return database.RemoveContact(username);
        }

        public void Logout(IUser user)
        {
            if (database == null)
            {
                database = new Database();
            }
            database.Logout(user);
        }

        public void GetAllOnlineAccounts()
        {
            //Need to implement the code
        }

        IUser IDatabase.Logout(string username)
        {
            throw new NotImplementedException();
        }

        IUser IDatabase.AddToContact(string username)
        {
            throw new NotImplementedException();
        }

        List<IUser> IDatabase.GetAllOnlineAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
