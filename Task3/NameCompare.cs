using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class NameCompare : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            return String.Compare(e1.Name, e2.Name);
        }
    }
}
