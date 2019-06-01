using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Organisation
    {
        public string Name;
        public List<Employee> Employees;

        public Organisation(string name)
        {
            Name = name;
            Employees = new List<Employee>();
            Console.WriteLine("Izveidots jauns uznemums {0}!", name);
        }

        public void AddEmployee(string name, string surname, string date)
        {
            Employees.Add(new Employee(name, surname, date));
            Console.WriteLine("Pievienots jauns darbinieks - {0} {1}", name, surname);
        }

        public void Fire(string name, string surname)
        {
            //system linq
            //lambda expression
            Employee employee = Employees.Find(e => e.Name == name && e.Surname == surname);
            if (employee == null)
            {
                Console.WriteLine("Darbinieks nav atrasts");
            }
            else
            {
                Employees.Remove(employee);
                Console.WriteLine("Darbinieks {0} {1} ir atlaists", name, surname);
            }
        }

        public void ChangeData(string name, string surname, string newDate)
        {
            //system linq
            //lambda expression
            Employee employee = Employees.Find(e => e.Name == name && e.Surname == surname);
            if (employee == null)
            {
                Console.WriteLine("Darbinieks nav atrasts");
            }
            else
            {
                employee.BirthDate = newDate;
                Console.WriteLine("Mainiti darbinieka {0} {1} dati", name, surname);
            }
        }

        public void PrintAllEmployees()
        {
            //1.variants
            //foreach (Employee e in Employees)
            //{
            //    Console.WriteLine("{0} {1} dz. {2}", e.Name, e.Surname, e.BirthDate);
            //}

            //2.variants
            Employees.ForEach(e=>
            {
                Console.WriteLine("{0} {1} dz. {2}", e.Name, e.Surname, e.BirthDate);
            });
        }
    }
}
