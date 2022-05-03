using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace Chat_Library
{
    public class Database
    {
        //Make list of all online users
        //Make list of all the chats tha are active

        private string FileName = "..\\..\\..\\Websocket-Client\\bin\\Debug\\AllUsers.txt";

        /// <summary>
        /// List of all online users
        /// </summary>
        public List<IUser> OnlineUsers = new List<IUser>();

        /// <summary>
        /// List of all active chats
        /// </summary>
        public List<List<User>> ActiveChats = new List<List<User>>();

        public List<User> AdminUsers = new List<User>();

        //Stores all users as IUser instead of key value pair
        public List<IUser> UserList = new List<IUser>();

        JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new CustomJsonContractResolver(),
            PreserveReferencesHandling = PreserveReferencesHandling.Objects
        };

        public Database()
        {
            using (StreamReader reader = new StreamReader(FileName, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    IUser currentUser = DeSerializeAccount(line);
                    if (currentUser.GetStatus().Equals("Online"))
                    {
                        OnlineUsers.Add(currentUser);
                    }
                    else
                    {
                        OnlineUsers.Remove(currentUser);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IUser Login(string username, string password)
        {

           
            //Create new user
            User newUser = new User(username, password);
            string newUserAdd = SerializeAccount(newUser);
            IUser existingUser = new User(username, password);
            bool exist = false;
            bool changeStatus = false;
   
            using (StreamReader reader = new StreamReader("AllUsers.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(newUser.UserName))
                    {
                        changeStatus = true;
                        existingUser = DeSerializeAccount(line);
                        exist = true;
                    }
                    continue;
                }
                reader.Close();
            }
            if (changeStatus)
            {
                existingUser.ChangeStatus("Online");
                UpdateContact(existingUser);
            }
            if (!exist)
            {
                using (StreamWriter writer = new StreamWriter("AllUsers.txt", true))
                {
                    writer.WriteLine(newUserAdd);
                    return newUser;
                }
                
            }
            UserList.Add(newUser);
            //Return new user
            return existingUser;
            
        }

        public void Logout(IUser user)
        {
            user.ChangeStatus("Offline");
            UpdateContact(user);

        }

        public User AddtoContact(string username)
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
                reader.Close();
            }
            return null;
        }

        public User RemoveContact(string username)
        {
            using (StreamReader reader = new StreamReader("AllUsers.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    dynamic data = JObject.Parse(line);
                    if (data.UserName == username)
                    {
                        return DeSerializeAccount(line);
                    }
                    continue;
                }
                //If we don't find any user with given username
                reader.Close();
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
                reader.Close();
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
            string jsonString = JsonConvert.SerializeObject(user,Settings);
            return jsonString;
        }

        private User DeSerializeAccount(string stringUser)
        {
            var user = JsonConvert.DeserializeObject<User>(stringUser);
            return user;

        }

        

        public void GetAllOnlineAccounts()
        {

        }

        public List<IUser> GetUsersFromFile()
        {
            // need to deserialize the object in the text file
            // add it to the list of users 
            // return the list of all users in the text file
            List<IUser> users = new List<IUser>();
            using (StreamReader sr = new StreamReader("C:/Users/tucke/Desktop/New folder/Websocket-Client/bin/Debug/AllUsers.txt"))
            {
                while (!sr.EndOfStream)
                {
                    IUser user = DeSerializeAccount(sr.ReadLine());
                    users.Add(user);
                    if (user.GetStatus().Equals("Online"))
                    {
                        OnlineUsers.Add(user);
                    }
                    UserList.Add(user);
                    // need to deserialize the object in the text file
                    // add it to the list of users 
                    // return the list of all users in the text file
                    // need to change the return type of this methode back to List<IUser>
                }
            }
            return users;
        }
    }
}
