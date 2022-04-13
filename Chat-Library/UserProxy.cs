using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Users contact list all of their friends
        /// </summary>
        public List<User> Contacts { get; set; }

        public UserProxy(User user)
        {
            this._user = user;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<User> UpdateContactList(User user)
        {
            return _user.UpdateContactList(user);
            
        }




    }
}
