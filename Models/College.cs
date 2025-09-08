using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_demo.Models
{
    public class College : IEdicationalinstitution
    {
        public void Teach(Person person)
        {
            Console.WriteLine("Studying at College.");
        }
    }
}
