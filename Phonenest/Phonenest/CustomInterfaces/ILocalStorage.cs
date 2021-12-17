using System;
using System.Collections.Generic;
using System.Text;

namespace Phonenest.CustomInterfaces
{
    interface ILocalStorage
    {
        void Save(object file, string path);
        object Load(string path);
    }
}
