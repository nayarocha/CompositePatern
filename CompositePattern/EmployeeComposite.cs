using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class EmployeeComposite : EmployeeComponent
    {
        private IList<EmployeeComponent> employees;

        public EmployeeComposite(String name) : base(name) 
        {
            employees = new List<EmployeeComponent>();
        }

        public void AddEmployee(EmployeeComponent e) 
        {
            employees.Add(e);
        }

        public void RemoveEmployee(EmployeeComponent e)
        {
            employees.Remove(e);
        }

        public override void PrintSupervisorOf(int spacing)
        {
            for (int c = 0; c< spacing; c++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Name);

            foreach (EmployeeComponent e in employees)
            {
                e.PrintSupervisorOf(spacing + 1);
            }
        }    
    }
}
