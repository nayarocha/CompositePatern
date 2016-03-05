using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class EmployeeComponent
    {
        public string Name { private set; get; }

        public EmployeeComponent(string name)
        {
            this.Name = name;
        }
        
        public virtual void PrintSupervisorOf(int spacing)
        {
            for (int c = 0; c < spacing; c++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Name);
        }

        
    }
}
