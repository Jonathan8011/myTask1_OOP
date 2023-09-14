using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Cow : Mammal
    {
        protected int Milking;
        
        public Cow(string name, int age, bool isHunter, int caloris, int milkCalories, int pregnancyMoths, int Num) : base( name,  age,  isHunter,  caloris,  milkCalories,  pregnancyMoths){
            Milking = milkCalories;
        }

        public int getMilking() { return Milking; }
        public void setMilkingf(int Milking) { this.Milking = Milking; }

        public override string ToString()
        {
            return base.ToString()+$" Cow";
        }

        public new int eat()
        {
            return base.eat() / 4;
        }
    }
}
