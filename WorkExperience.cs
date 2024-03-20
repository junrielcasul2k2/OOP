using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class WorkExperience : Course
    {
        private string workDesc;
        private int NoofExperience;
    
        public WorkExperience(string workDesc, int noofExperience, 
                                string fName, string lName, int age, string Course, int YrLvl) 
                                :base(Course,YrLvl,fName,lName,age)
        {
            this.workDesc = workDesc;
            NoofExperience = noofExperience;
        }

        public string getWorkDesc() 
        {
            return this.workDesc;
        }
        public int getNoofExperience()
        {
            return this.NoofExperience;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine();
            Console.WriteLine("\nWork: " +workDesc+ "\nNo. of Experience: "+NoofExperience);
        }
    }
}
