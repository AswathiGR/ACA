using ACA.Chalavara.Authentication.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Chalavara.Authentication.interfaces
{
    public interface IFireBaseAuthenticator
    {
        Task<AppUser> LoginWithGoogle(string idTok, string accesTok);

    }
}
