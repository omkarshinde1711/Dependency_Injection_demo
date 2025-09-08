using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_demo.Models
{
    public class Hospital
    {
        internal void Cure(Person person)
        {
            Console.WriteLine("Getting treatment at hospital.");
        }
    }
}
