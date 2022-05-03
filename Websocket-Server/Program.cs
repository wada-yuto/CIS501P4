using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Websocket_Server
{ 
    class Program
    {
        static void Main(string[] args)
        {
           
            var wss = new WebSocketServer(8001);
            AdminLogin adminlogin = new AdminLogin();
            Server serv = new Server();
            AdminPanel adminPanel = new AdminPanel();
            serv.SetUp(adminPanel.UpdateOnlineUserList);

            //hard coded admin
            

            wss = new WebSocketServer(8001);

            // Add the Echo websocket service
            wss.AddWebSocketService<Echo>("/echo");

            // Add the Chat websocket service
            wss.AddWebSocketService<Server>("/chat");
            wss.Start();
            Application.Run(adminlogin);
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

            wss.Stop();

        }
    }
}