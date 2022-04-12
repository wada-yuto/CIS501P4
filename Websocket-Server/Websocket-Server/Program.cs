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

            while (serverStatus == false)
            {
                Console.WriteLine("Enter Admin Username: ");
                string tempAdminUser = Console.ReadLine();

                foreach (string s in adminCredentials.Keys)
                {
                    if (s.Equals(tempAdminUser))
                    {
                        Console.WriteLine("Enter Admin Password: ");
                        string tempAdminPass = Console.ReadLine();
                        foreach (string t in adminCredentials.Values)
                        {
                            if (t.Equals(tempAdminPass))
                            {
                                serverStatus = true;

                                // Start the server
                                wss.Start();
                            }
                        }
                    }
                }
            }

            AdminPanel form = new AdminPanel();
            form.Show();

            Console.WriteLine("\n Server Is Online");
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
            

            // Stop the server
            wss.Stop();
        }
    }
}
