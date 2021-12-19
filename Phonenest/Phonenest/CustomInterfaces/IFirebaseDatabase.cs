using System;
using System.Collections.Generic;
using System.Text;

namespace Phonenest.CustomInterfaces
{
    public interface IFirebaseDatabase
    {
        //event EventHandler<EventArgs> StoreDataChanged;
        IStore GetStore();
    }
}
