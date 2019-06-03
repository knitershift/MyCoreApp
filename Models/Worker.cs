using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Worker
    {
     
        public string Name { get; set; }
        public int Sallary { get; set; }
        public int Bonus { get; set; }

        public Worker(string Name, int Sallary, int Bonus)
        {
            this.Name = Name;
            this.Sallary = Sallary;
            this.Bonus = Bonus;
        }

        public int TotalSallary() {
            return Sallary + Bonus;
        }

    }
}
