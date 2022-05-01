﻿using System;
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


        string GetUsername();

        string GetPassword();

        string GetStatus();

        int GetServerID();

        BindingList<IUser> GetContactList();


    }
}
