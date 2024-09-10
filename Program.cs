using TaxesProject.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace TaxesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employeeList = new List<Employees>();
            Console.WriteLine("Insert the number of emplooyers" );
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = Char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures:");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        employeeList.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberofEmployees = int.Parse(Console.ReadLine());
                    employeeList.Add(new Company(name, anualIncome, numberofEmployees));
                }
                double sum = 0.0;
                Console.WriteLine();
                Console.WriteLine("TAXES PAID:");
                foreach (Employees tp in employeeList)
                {
                    double tax = tp.Taxes();
                    Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                    sum += tax;
                }

                Console.WriteLine();
                Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
