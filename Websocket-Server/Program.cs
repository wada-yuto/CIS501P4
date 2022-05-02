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
            bool serverStatus = false;
            Dictionary<String, String> adminCredentials = new Dictionary<string, string>();
            adminCredentials.Add("admin", "password");

            // Start a websocket server at port 8001
            var wss = new WebSocketServer(8001);

            // Add the Echo websocket service
            wss.AddWebSocketService<Echo>("/echo");

            // Add the Chat websocket service
            wss.AddWebSocketService<Chat>("/chat");

            AdminLogin adminlogin = new AdminLogin();


            wss.Start();
            Console.WriteLine("\n Server Is Online");
            Application.Run(adminlogin);
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();


            // Stop the server
            wss.Stop();
        }
    }
}
