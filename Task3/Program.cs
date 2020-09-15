using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> l = new List<Employee>(3);
            Employee.MakeEmployeeList(l, 3);
            Employee.ShowEmployeeList(l);

            l.Sort(new NameCompare());
            Employee.ShowEmployeeList(l);

            l.Sort(new SalaryCompare());
            Employee.ShowEmployeeList(l);
        }
    }
}
