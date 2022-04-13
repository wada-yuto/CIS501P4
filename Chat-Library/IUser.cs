using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Library
{
    /// <summary>
    /// Interface for User class
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// UserName that can be get or set
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Password that can be get or set
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Users online status
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// Contact list
        /// </summary>
        List<User> Contacts { get; set; }


    }
}
