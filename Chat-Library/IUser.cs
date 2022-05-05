using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Chat_Library
{
    /// <summary>
    /// Interface for User class
    /// </summary>
    public interface IUser
    {

        string UserName { get; set; }

        string Password { get; set; }

        string Status { get; set; }

        string ServerID { get; set; }

        void AddContact(object user);

        void RemoveContact(object user);

        List<IUser> GetContactList();



    }
}
