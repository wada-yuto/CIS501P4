using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Library
{
    interface IDatabase
    {
        /// <summary>
        /// Used to log in the chat
        /// </summary>
        /// <param name="username">Name of the username that is logging in</param>
        /// <returns>Returns the IUser that logged in</returns>
        IUser Login(string username, string password);

        /// <summary>
        /// Used to log out of the chat
        /// </summary>
        /// <param name="username">Name of the username that need to be logged out</param>
        /// <returns>Returns IUser that logged out</returns>
        IUser Logout(string username);

        /// <summary>
        /// Method to add user to the contact
        /// </summary>
        /// <param name="username">Username of the user that needs to be added to thec contact</param>
        /// <returns>Returns IUser that is added to the contact</returns>
        IUser AddToContact(string username);

        /// <summary>
        /// Method to return all the users that are online
        /// </summary>
        /// <returns>Returns all the users that are online</returns>
        List<IUser> GetAllOnlineAccounts();

    }
}
