using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Library
{
    public class DatabaseProxy : IDatabase
    {
        /// <summary>
        /// List of all the Online Users
        /// </summary>
        public List<IUser> OnlineUsers;

        private Database database;

        public DatabaseProxy()
        {
            
        }

        public IUser Login(string username, string password)
        {
            if(database == null)
            {
                database = new Database();
            }
            return database.Login(username, password);
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
