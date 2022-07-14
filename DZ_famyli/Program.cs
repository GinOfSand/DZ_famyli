using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_famyli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Иврам","Соулргорв", 2020);
            Console.WriteLine(a.Year+" Год зачисления");
            Console.WriteLine(a.GetFullName());
            Console.WriteLine(a.GetCourse());

        }
    }
}
