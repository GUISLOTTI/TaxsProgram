using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesProject.Entities
{
    class Employees
    {
        public string Name { get; set; }
        public double AnualIncome {  get; set; }

        public Employees() 
        { 
        }
        public Employees(string name, double anualIncome)
        {
            this.Name = name;
            this.AnualIncome = anualIncome;
        }
        public virtual double Taxes()
        {
            return 0;
        }
    }
}
