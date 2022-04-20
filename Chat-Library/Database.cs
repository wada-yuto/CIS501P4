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

        public Dictionary<string, string> AllUsers = new Dictionary<string, string>();

        //Stores all users as IUser instead of key value pair
        public List<IUser> UserList = new List<IUser>();

        public Database()
        {
        }

        public IUser Login(string username, string password)
        {
            foreach (KeyValuePair<String, string> pair in AllUsers)
            {
                if (pair.Key.Equals(username))
                {
                    if (pair.Value.Equals(password))
                    {
                        User user = new User(username, password);
                        UserList.Add(user);
                        //Return existing user
                        return user;
                    }
                }
            }

            //Add user that is not in the dictionary
            AllUsers.Add(username, password);
            User newUser = new User(username, password);
            UserList.Add(newUser);
            //Return new user
            return newUser;
        }

        public void Logout(string username)
        {

        }

        public IUser AddtoContact(string username)
        {
            foreach(User user in UserList)
            {
                if (user.UserName.Equals(username))
                {
                    return user;
                }
            }
            //If we don't find any user with given username
            return null;
        }

        public void GetAllOnlineAccounts()
        {

        }
    }
}
