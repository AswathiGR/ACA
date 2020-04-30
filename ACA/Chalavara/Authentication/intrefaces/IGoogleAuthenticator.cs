using ACA.Chalavara.Authentication.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACA.Chalavara.Authentication.intrefaces
{
    public interface IGoogleAuthenticator
    {
        void Login(Action<GoogleUser, string> OnLoginComplete);
        void Logout();
    }
}