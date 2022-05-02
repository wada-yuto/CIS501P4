using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using Chat_Library;

namespace Websocket_Server
{
    // Task I:  Modify this websocket behavior so that it remembers all messages.
    //          Whenever there is a new client connected, send all stored messages to the client
    //          so the client knows the history of the conversation.
    // Task II: Add timestamp (just the hour and minute) to the messages
    //          (see http://stackoverflow.com/questions/21219797/how-to-get-correct-timestamp-in-c-sharp
    //           for an example on how to get a timestamp).
    
    public class Server : WebSocketBehavior
    {
        private UpdateOnlineUserListDel UpdateOnlineUserListDelegate;
        public static List<string> history = new List<string>();
        private static int count;

        public void UpdateUserList(List<IUser> ActiveUsers)
        {
            //ActiveUsers = uxActiveUsersListBox

        }

        public void UpdateChatList(List<IUser> Users)
        {

        }

        protected override void OnClose(CloseEventArgs e)
        {
           //When User closes the form, what should it do?
        }

        protected override void OnOpen()
        {
            count = 0;
            foreach(string message in history)
            {
                count++;
                Sessions.SendTo(this.ID, count.ToString() + " " + message);
            }
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            // Retrieve message from client
            string msg = e.Data;
            history.Add(e.Data);

            // Broadcast message to all clients
            Sessions.Broadcast(msg);
        }
    }
}
