using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat_Library;

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
        public string Password { get; set; }

        /// <summary>
        /// Users Status online or offline
        /// </summary>
        public string Status { get; set; }

        public int ServerID { get; set; }

        /// <summary>
        /// Users contact list all of their friends
        /// </summary>
        public List<User> Contacts { get; set; }

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

        public List<IUser> GetContactList()
        {
            throw new NotImplementedException();
        }

        BindingList<IUser> IUser.GetContactList()
        {
            throw new NotImplementedException();
        }





    }
}
