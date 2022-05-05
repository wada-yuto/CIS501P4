using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using Chat_Library;
using Newtonsoft.Json;

namespace Websocket_Server
{

    public enum StateOfServer
    {
        Start,
        Display,
        UpdateChat,
        UpdateUsers

    }

    public delegate void UpdateUserListDel(List<IUser> activeUsers);
    public class Server : WebSocketBehavior
    {
        public Database database;
        public StateOfServer state = StateOfServer.Start;
        public List<IUser> activeUsers;
        public List<IUser> activeChats;
        UpdateUserListDel updateUser;

        public Server(Database db, List<IUser> users, List<IUser> chats)
        {
            this.database = db;
            this.activeUsers = users;
            this.activeChats = chats;
        }

        public Server()
        {

        }
        protected override void OnClose(CloseEventArgs e)
        {
            //When User closes the form, what should it do?
        }

        protected override void OnOpen()
        {
            string text = this.SerializeObject(database);
            Sessions.SendTo(this.ID, text);
            state = StateOfServer.Display;
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            switch (state)
            {
                case StateOfServer.Display:
                    switch (e.Data)
                    {
                        case "CLIENTLOGIN":
                            string text = this.SerializeObject(this.database);
                            Sessions.Broadcast(text);
                            return;
                        case "CLIENTLOGOUT":
                            string text2 = this.SerializeObject(database);
                            Sessions.Broadcast(text2);
                            activeUsers = new List<IUser>();
                            foreach(User user in database.OnlineUsers)
                            {
                                activeUsers.Add(user);
                            }
                            state = StateOfServer.UpdateUsers;
                            updateUser(activeUsers);
                            state = StateOfServer.Display;
                            return;

                            object obj = this.DeSerializeObject(e.Data);
                            if(obj is User u)
                            {
                                u.ServerID = this.ID;
                                foreach(User user in database.OnlineUsers)
                                {
                                    if (u.Contacts.Contains(user))
                                    {
                                        u.Contacts.Remove(user);
                                        u.Contacts.Add(user);
                                    }
                                }

                                string JsonText = this.SerializeObject(u);
                                if(u.Status == "Online")
                                {
                                    if (activeUsers.Contains(u))
                                    {
                                        activeUsers.Remove(u);
                                    }
                                    if (database.OnlineUsers.Contains(u))
                                    {
                                        database.OnlineUsers.Remove(u);
                                    }
                                    Sessions.Broadcast(JsonText);
                                }
                                else
                                {
                                    if(database.OnlineUsers.Contains(u) == false)
                                    {
                                        database.OnlineUsers.Add(u);
                                        if(database.OnlineUsers.Count != activeUsers.Count)
                                        {
                                            activeUsers = new List<IUser>();
                                            foreach(User user in database.OnlineUsers)
                                            {
                                                activeUsers.Add(u);
                                            }
                                        }
                                    }
                                    Sessions.Broadcast(JsonText);
                                }
                                state = StateOfServer.UpdateUsers;
                                updateUser(activeUsers);
                                state = StateOfServer.Display;
                            }
                    }
                    break;
            }
        }

        private string SerializeObject(object obj)
        {
            string text = "";
            text = JsonConvert.SerializeObject(obj);
            return text;
        }

        private object DeSerializeObject(string incomingObj)
        {
            object obj;
            obj = JsonConvert.DeserializeObject<User>(incomingObj);
            if (obj is User u)
            {
                if (u.UserName != null) { return obj; }
            }

            return null;
        }

        public void Setup(UpdateUserListDel updateuserdelegate)
        {
            updateUser = updateuserdelegate;
        }

       
    }
}
