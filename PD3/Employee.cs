using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string BirthDate { get; set; }
            
        public Employee(string name, string surname, string birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}
