using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Chat_Library;
using Websocket_Server;

namespace Websocket_Client_Chat
{
    public delegate bool Message(string message);
    public class ChatController
    {
        private string name;
        public WebSocket ws;

        // Event for when a message is received from the server
        public event Message MessageReceived;
        public ChatController()
        {
            //this.name = name;

            //// Connects to the server
            ws = new WebSocket("ws://127.0.0.1:8001/chat");
            ws.OnMessage += (sender, e) => { if (MessageReceived != null) MessageReceived(e.Data); };
            ws.Connect();
        }

        // Handles when a new message is entered by the user
        public bool MessageEntered(string message)
        {
            // Send the message to the server if connection is alive
            if (ws.IsAlive)
            {
                ws.Send(name + ": " + message);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateContactListLogic()
        {
            

            
        }

        public IUser CheckDatabase(string username, string password)
        {
            DatabaseProxy database = new DatabaseProxy();
            return database.Login(username, password);

            //Create object of type IDatabase,
            //Check to see if the user is in the populated file(text file),
            //We can replace this with list
            //Call Login(username, password) form database
            
        }

        public IUser AddToContactListLogic(string username)
        {
            DatabaseProxy database = new DatabaseProxy();
            IUser user = database.AddToContact(username);
            return user;          
        }

        // Makes sure to close the websocket when the controller is destructed
        ~ChatController()
        {
            ws.Close();
        }
    }
}
