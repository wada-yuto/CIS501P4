using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Library
{
    public class Database
    {
        //Make list of all online users
        //Make list of all the chats tha are active

        /// <summary>
        /// List of all online users
        /// </summary>
        public List<User> OnlineUsers = new List<User>();

        /// <summary>
        /// List of all active chats
        /// </summary>
        public List<List<User>> ActiveChats = new List<List<User>>();

        public Database()
        {

        }

        public IUser Login(string username)
        {
            
        }

        public IUser Logout(string username)
        {

        }

        public IUser AddtoContact(string username)
        {

        }

        public List<IUser> GetAllOnlineAccounts()
        {

        }
    }
}
