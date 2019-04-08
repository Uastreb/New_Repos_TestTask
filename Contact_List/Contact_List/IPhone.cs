using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contact_List
{
    public interface IPhone
    {
        Task Call(string phoneNumber);
    }
}
