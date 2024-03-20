using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string fname, lname, course, work;
             int yearLevel, age, NoEx;

            Console.Write("Enter firstname: ");
            fname = Console.ReadLine();
            Console.Write("Enter lastname: ");
            lname = Console.ReadLine();
            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course: ");
            course = Console.ReadLine();
            Console.Write("Enter YearLevel: ");
            yearLevel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Work: ");
            work = Console.ReadLine();
            Console.Write("Enter No. of Experience: ");
            NoEx = Convert.ToInt32(Console.ReadLine());

            WorkExperience obj = new WorkExperience(work,NoEx,fname,lname,age,course,yearLevel);

            obj.displayInfo();

        }
    }
}
