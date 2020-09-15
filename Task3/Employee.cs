using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Task3
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
            Name = "";
            Salary = 0;
        }
        public Employee(string n, int s)
        {
            Name = n;
            Salary = s;
        }
        public static void MakeEmployeeList(List<Employee> l, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("enter name: ");
                string name = Console.ReadLine();
                Console.Write("enter salary: ");
                int salary = Convert.ToInt32(Console.ReadLine());
                l.Add(new Employee(name, salary));
            }
        }
        public static void ShowEmployeeList(List<Employee> l)
        {
            Console.WriteLine("count = " +l.Count);
            for (int i = 0; i < l.Count; i++)
                Console.WriteLine(i+" : name: "+l[i].Name+" | salary: "+l[i].Salary);
            Console.WriteLine();
        }
    }

    class NameCompare : IComparer<Employee>
    {
       public int Compare(Employee e1, Employee e2)
       {
            return String.Compare(e1.Name, e2.Name);    
       }
    }

    class SalaryComapare : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            if (e1.Salary > e2.Salary)
                return 1;
            else if (e1.Salary < e2.Salary)
                return -1;
            else
                return 0;
        }
    }
}
