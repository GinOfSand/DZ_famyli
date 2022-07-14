using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_famyli
{
    internal class Student : User
    {
        public Student(string name, string surname, int year) : base()
        {
            Name = name;
            Surname = surname; 
            Year = year;
        }
        public string GetCourse()
        {
            string Cours = (DateTime.Now.Year - Year).ToString();
            if (Convert.ToInt32(Cours) > 5 || Convert.ToInt32(Cours) < 1)
            { 
                Cours = "Студент не зачислен или завершил обучение";
            }
            else
            {
                Cours = $"Студент учится на {Cours} курсе";
            }
            return Cours;
        }
    }
}
