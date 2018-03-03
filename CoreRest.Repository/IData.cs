using CoreRest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRest.Repository
{
    interface IData
    {
        IReadOnlyList<Employee> Employees();
        List<Profile> Profile();        
    }
}
