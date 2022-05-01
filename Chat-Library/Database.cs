using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Library
{
    public class Database
    {
        //Make list of all online users
        //Make list of all the chats tha are active

        private string FileName = "C:\\Users\\yuto808263\\Desktop\\CIS501Chat\\CIS501P4\\Chat-Library\\AllUsers.txt;";

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
            string user2 = SerializeAccount(newUser);
            bool exist = false;
            using (StreamReader reader = new StreamReader("AllUsers.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(newUser.UserName))
                    {
                        exist = true;
                    }
                    continue;
                }
            }
            if (!exist)
            {
                using (StreamWriter writer = new StreamWriter("AllUsers.txt", true))
                {
                    writer.WriteLine(user2);
                }
            }
            UserList.Add(newUser);
            //Return new user
            return newUser;
        }

        public void Logout(string username)
        {

        }

        public IUser AddtoContact(string username)
        {
            using (StreamReader reader = new StreamReader("AllUsers.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(username))
                    {
                        return DeSerializeAccount(line);
                    }
                    continue;
                }
                //If we don't find any user with given username

            }
            return null;
        }

        public void UpdateContact(IUser user)
        {
            int lineNumber = GetLine(user.GetUsername());
            string account = SerializeAccount(user);
            LineChanger(account, lineNumber);
        }

        /// <summary>
        /// Return the line number that username is at
        /// </summary>
        /// <param name="username">name of the user</param>
        /// <returns>line number that username is at</returns>
        private int GetLine(string username)
        {
            int lineNum = 0;
            using (StreamReader reader = new StreamReader("AllUsers.txt",true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNum++;
                    if (line.Contains(username))
                        return lineNum;
                }
            }
            return -1;


            //using (StreamReader reader = new StreamReader("AllUsers.txt", true))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        if (line.Contains(newUser.UserName))
            //        {
            //            exist = true;
            //        }
            //        continue;
            //    }
            //}
        }

        private void LineChanger(string newText, int lineNumber)
        {
            string[] arrLine = File.ReadAllLines("AllUsers.txt");
            arrLine[lineNumber - 1] = newText;
            File.WriteAllLines("AllUsers.txt", arrLine);
        }

        

        private string SerializeAccount(IUser user)
        {
            string jsonString = JsonConvert.SerializeObject(user);
            return jsonString;
        }

        private IUser DeSerializeAccount(string stringUser)
        {
            IUser user = JsonConvert.DeserializeObject<User>(stringUser);
            return user;

        }

        public void GetAllOnlineAccounts()
        {

        }

        public void GetUsersFromFile(string fileName)
        {
            // need to deserialize the object in the text file
            // add it to the list of users 
            // return the list of all users in the text file
            List<IUser> users = new List<IUser>();
            using(StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    // need to deserialize the object in the text file
                    // add it to the list of users 
                    // return the list of all users in the text file
                    // need to change the return type of this methode back to List<IUser>
                }
            }
        }
    }
}
