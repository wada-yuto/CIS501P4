using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat_Library;
using System.ComponentModel;

namespace Websocket_Server
{
    /// <summary>
    /// UserProxy that will be used by the server side
    /// </summary>
    public class UserProxy : IUser
    {
        /// <summary>
        /// Real User
        /// </summary>
        private User _user;

        /// <summary>
        /// Username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        private string Password { get; set; }

        /// <summary>
        /// Users Status online or offline
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// ID of the server
        /// </summary>
        public int ServerID { get; set; }

        /// <summary>
        /// Users contact list all of their friends
        /// </summary>
        public BindingList<User> Contacts { get; set; }

        public UserProxy(string username,  string password)
        {
            this.UserName = username;
            this.Password = password;
        }

        public string GetUsername()
        {
            return this.UserName;
        }

        public string GetPassword()
        {
            return this.Password;
        }

        public string GetStatus()
        {
            return this.Status;
        }

        public int GetServerID()
        {
            return this.ServerID;
        }

        public void ChangeStatus(string status)
        {
            this.Status = status;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public BindingList<User> GetContactList()
        {
            return this.Contacts;
            
        }




    }
}
