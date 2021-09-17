using System;
using System.Collections.Generic;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("How many employees will be registered? ");
            int emp = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= emp; i++) {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Funcionario f = new Funcionario(id, name, salary);
                list.Add(f);
            }

            Console.WriteLine();
            Console.Write("Enter the employee Id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            if (list.Find(x => x.Id == idIncrease) is null) {
                Console.WriteLine("This Id does not exist!");
            }
            else {
                Console.Write("Enter the percentage: ");
                double i = double.Parse(Console.ReadLine());
                int j = list.FindIndex(x => x.Id == idIncrease);
                list[j].IncreaseSalary(i);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Funcionario obj in list) {
                Console.WriteLine(obj.ToString());
            }

        }
    }
}