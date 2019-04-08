using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_List
{
    public interface ISQLite
    {
            string GetDatabasePath(string filename);
    }
}