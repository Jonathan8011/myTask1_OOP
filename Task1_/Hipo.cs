using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Hipo : Mammal
    {
        protected int Fat;

        public Hipo(string name, int age, bool isHunter, int caloris, int milkCalories, int pregnancyMoths, int fat) : base(name, age, isHunter, caloris, milkCalories, pregnancyMoths)
        {
            Fat = fat;
        }

        public int getFat() { return Fat; }
        public void setFat(int Fat) { this.Fat = Fat; }

        public override string ToString()
        {
            return base.ToString() + $" Hipo";
        }
    }
}
