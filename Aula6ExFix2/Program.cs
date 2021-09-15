using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;
    

namespace Aula6ExFix2 {
    class Program {
        static void Main(string[] args) {




            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase:");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == searchId);
            if (func != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                func.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list: ");
            foreach(Funcionario obj in list) {
                Console.WriteLine(obj);
            }
        }


    }
}

