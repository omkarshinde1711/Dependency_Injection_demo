using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Injection_demo.Models;

namespace Dependency_Injection_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();  // creating the dependency outside the person class
            Person person = new Person(home); // Constructor Injection
            person.TakeRefuge();


            person.GetTreatment(new Hospital()); // Method Injection

            person.School = new School();  // Property Injection
            person.Study();

            person.School = new College();  // Property Injection
            person.Study(); // changing the dependency at runtime

            Console.ReadLine();
        }
    }
}
