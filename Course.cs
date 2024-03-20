using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Course : Registration   
    {
        private string coursedesc;
        private int yearLevel;

        public Course(string coursedesc, int yearLevel,string Fname,string lName, int age) 
                        : base(Fname,lName,age)
        {
            this.coursedesc = coursedesc;
            this.yearLevel = yearLevel;
        }

        public string getCoursedesc() 
        {
            return this.coursedesc;
        }
        public int getyearLevel() 
        {
            return this.yearLevel;
        }
        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine();
            Console.WriteLine("\nCourse: " +coursedesc+ "\nYearLevel: " +yearLevel);
        }

    }
}
