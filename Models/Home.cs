using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_demo.Models
{
    public class Home
    {
        internal void ProvideShelter(Person person)
        {
            Console.WriteLine("Taking refuge at home.");
        }
    }
}
