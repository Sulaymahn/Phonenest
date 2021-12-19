using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Phonenest.CustomInterfaces
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithEmailAndPass(string email, string password);
        Task<bool> AddUser(string email, string password);
        bool SignOut();
        bool IsSignIn();
    }
}
