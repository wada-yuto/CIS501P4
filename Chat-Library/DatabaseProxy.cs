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

        public IUser Login(string username)
        {
            if(database == null)
            {
                database = new Database();
            }
            return database.Login(username);
        }

        public IUser Logout(string username)
        {
            if (database == null)
            {
                database = new Database();
            }
            return database.Login(username);
        }

        public IUser AddToContact(string username)
        {
            //Need to implement the code
        }

        public List<IUser> GetAllOnlineAccounts()
        {
            //Need to implement the code
        }


    }
}
