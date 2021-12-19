using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Phonenest.CustomInterfaces
{
    public interface ILocalStorage
    {
        void SaveCredential(string email, string password);
        string[] GetCredential();
        void DeleteCredential();
    }
}
