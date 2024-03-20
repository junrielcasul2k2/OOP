using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Registration
    {

        private string firstname;
        private string lastname;
        private int age;

        public Registration(string firstname, string lastname, int age) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public string getFname() 
        {
            return this.firstname;
        }
        public string getLname() 
        {
            return this.lastname;
        }
        public int getAge() 
        { 
            return this.age;
        }

        public virtual void displayInfo() 
        {
            Console.WriteLine();
            Console.WriteLine("Firstname: " +firstname+ "\nLastname: " +lastname+ 
                                "\nAge: "+age);
        }
    }
}
