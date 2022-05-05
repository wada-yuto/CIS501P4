using Chat_Library;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var wss = new WebSocketServer(8001);

            AdminLogin adminlogin = new AdminLogin();
            AdminPanel panel = new AdminPanel();
           

            //hard coded admin
            

            wss = new WebSocketServer(8001);

            Database database = new Database();
            List<IUser> u = new List<IUser>();
            List<IUser> u2 = new List<IUser>();

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