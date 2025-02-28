using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    internal class Plesen
    {
        private int age {  get; set; }
        int retirementAge {  get; set; }
         public Plesen()
        {
        }
        public Plesen(int age, int retirementAge)
        {
            this.age = age;
            this.retirementAge = retirementAge;
        }

         public bool CheckAge()
        {
            int retirementAge = 65;

            if (age >= retirementAge)
            {
                Console.WriteLine("Уже на пенсии.");
            }
            else
            {
                int yearsLeft = retirementAge - age;
                Console.WriteLine($"Осталось {yearsLeft} лет до пенсии.");
            }
            return true;

        }




    }
}
