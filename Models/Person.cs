using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_demo.Models
{
    public class Person
    {   
        private Home _home;
        private IEdicationalinstitution _school; // using interface for school to achieve loose coupling


        //private Hospital _hospital; // No need of this anymore coz will use method injection for hospital

        public IEdicationalinstitution School
        {
            set
            {
                _school = value;
            }
        }

        // Default constructor initializing dependencies

        //Constructor Injection

        // we will pass home as a parameter to the constructor of person class
        public Person(Home home)
        {
            //_home = new Home();   // we are not doing this anymore
            _home = home;          // we are doing this now


            // No need of this anymore because we will use property injection for school
            //_school = new School();

            // No need of this anymore because we will use method injection for hospital
            //_hospital = new Hospital();
        }


        public void TakeRefuge()
        {
            _home.ProvideShelter(this);

        }

        public void Study()
        {
            if(_school != null)
            {
                _school.Teach(this);
            }
            else
            {
                Console.WriteLine("No school assigned.");
            }

        }

        // Method Injection
        public void GetTreatment(Hospital hospital)
        {
            hospital.Cure(this);

        }

    }
}
