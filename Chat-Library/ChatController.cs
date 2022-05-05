using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Chat_Library;

namespace Websocket_Client_Chat
{
    public enum StateOfChat
    {
        START,
        WAITING,
        LOGIN,
        ADDCONTACT,
        REMOVECONTACT,
        LOGOUT,
        CHAT,
    };

    public delegate bool Message(string message);
    public delegate void UpdateContactListDel(List<IUser> contacts);
    public class ChatController
    {

        UpdateContactListDel UpdateContactList;
        WebSocket ws;
        IUser UserProxy;
        StateOfChat state;
        IDatabase databaseProxy;
        string name;
        Database db = new Database();


        // Event for when a message is received from the server
        public event Message FormMessage;
        public ChatController()
        {

            //// Connects to the server
            ws = new WebSocket("ws://127.0.0.1:8001/chat");
            ws.OnMessage += (sender, e) => this.MessageReceived(e.Data);
            ws.Connect();
        }

        public bool MessageEntered(string message)
        {
            // Send the message to the server if connection is alive
            if (ws.IsAlive)
            {
                ws.Send(name + ": its hitting this one" + message);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setNameLogic(User u)
        {
            name = u.UserName;
        }

        // Handles when a new message is entered by the user
        public bool MessageReceived(string message)
        {
            if (message.Equals("CLOSE"))
            {
                //logout the chats
                return true;
            }

            Object obj = this.DeserializeObject(message);
            if (obj is IUser user)
            {
                if (UserProxy != null && UserProxy.UserName.Equals(user.UserName) == false)
                {
                    foreach (IUser user2 in UserProxy.GetContactList())
                    {
                        if (user2.UserName.Equals(user.UserName))
                        {
                            UserProxy.RemoveContact(user2);
                            UserProxy.AddContact(user);
                            return true;
                        }
                    }
                    return false;
                }
                if (state == StateOfChat.LOGIN)
                {
                    if(user is User u)
                    {
                        if(UserProxy != null)
                        {
                            UserProxy.ServerID = u.ServerID;
                            if(UserProxy is ProxyUser p)
                            {
                                p.remoteUser = u;
                                UserProxy = p;
                            }
                        }
                        else
                        {
                            UserProxy = new ProxyUser(u, u.UserName, u.Password);
                        }
                    }
                    state = StateOfChat.WAITING;
                    return true;
                }
                else if(state == StateOfChat.ADDCONTACT)
                {
                    UserProxy.AddContact(user);
                    UpdateContactList(UserProxy.GetContactList());
                    state = StateOfChat.WAITING;
                    return true;
                }
            }
            else if (obj is Database database)
            {
                databaseProxy = new DatabaseProxy(database);
                if(UserProxy is ProxyUser pa)
                {
                    List<User> u = pa.remoteUser.Contacts;
                    List<User> newlist = new List<User>();
                    foreach(User ru in u)
                    {
                        if (database.OnlineUsers.Contains(ru))
                        {
                            ru.Status = "Online";
                            newlist.Add(ru);
                        }
                        else
                        {
                            ru.Status = "Offline";
                            newlist.Add(ru);
                        }
                    }

                    pa.remoteUser.Contacts = newlist;
                    UserProxy = pa;
                }
            }
            return false;
        }

        private object DeserializeObject(string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateContactListLogic(IUser user)
        {
            DatabaseProxy database = new DatabaseProxy(db);
            database.UpdateContact(user);

        }

        public IUser CheckDatabase(string username, string password)
        {
            DatabaseProxy database = new DatabaseProxy(db);
            return database.Login(username, password);

            //Create object of type IDatabase,
            //Check to see if the user is in the populated file(text file),
            //We can replace this with list
            //Call Login(username, password) form database

        }

        public User AddToContactListLogic(string username)
        {
            DatabaseProxy database = new DatabaseProxy();
            User user = database.AddToContact(username);
            return user;
        }

        public User RemoveContactListLogic(string username)
        {
            DatabaseProxy database = new DatabaseProxy();
            User user = database.RemoveContact(username);
            return user;
        }

        

        public void LogoutLogic(IUser user)
        {
            DatabaseProxy database = new DatabaseProxy();
            database.Logout(user);
        }

        // Makes sure to close the websocket when the controller is destructed
        ~ChatController()
        {
            ws.Close();
        }
    }
}
