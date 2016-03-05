using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeComposite j = new EmployeeComposite("joao");
            Employee bob = new Employee("Bob esponja");
            Employee hulk = new Employee ("Hulk");

            EmployeeComposite chaves = new EmployeeComposite("chaves");
            EmployeeComposite chiq = new EmployeeComposite("Chiquinha");
            Employee madr = new Employee("Seu madruga");
            Employee ki = new Employee("kiko");


            EmployeeComposite naya = new EmployeeComposite("nayara rocha");
            naya.AddEmployee(j);
            naya.AddEmployee(chaves);

            j.AddEmployee(bob);
            j.AddEmployee(hulk);

            chaves.AddEmployee(chiq);

            chiq.AddEmployee(madr);
            chiq.AddEmployee(ki);

            naya.PrintSupervisorOf(0);
            Console.ReadKey();

        }
    }
}
