using CoreRest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRest.Repository
{
<<<<<<< HEAD
    public interface IData
=======
    interface IData
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
    {
        IReadOnlyList<Employee> Employees();
        List<Profile> Profile();        
    }
}
