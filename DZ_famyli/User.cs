using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_famyli
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }

        public User(string nmae = "Name", string surname = "Surname", int year = 2010)
        {
            Name = nmae;
            Surname = surname;
            Year = year;
        }
        public string GetFullName() 
        { 
            return "Полное имя : "+$"{Name}"+" "+$"{Surname}"; 
        }
    }
}
