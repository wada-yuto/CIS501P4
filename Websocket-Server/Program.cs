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

            AdminLogin adminlogin = new AdminLogin();

            Application.Run(adminlogin);
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

        }
    }
}