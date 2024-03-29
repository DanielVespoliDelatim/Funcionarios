﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula6ExFix2 {
    class Funcionario {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }



        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100.00;
        }


        public override string ToString() {
            return "Updated list of emplooyes: "
                + Id
                + ", "
                + Name
                + ", " 
                + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }

}
