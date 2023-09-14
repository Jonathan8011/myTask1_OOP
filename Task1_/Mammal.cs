using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Mammal : Animal
    {
        protected int MilkCalories;
        protected int PregnancyMoths;

        public Mammal(string name, int age, bool isHunter, int caloris, int milkCalories, int pregnancyMoths) : base(name, age, isHunter, caloris)
        {
            MilkCalories = milkCalories;
            PregnancyMoths = pregnancyMoths;
        }


        public int getMilkCalories() { return MilkCalories; }
        public void setMilkCalories(int MilkCalories) { this.MilkCalories = MilkCalories; }

        public int getPregnancyMoths() { return PregnancyMoths; }
        public void setPregnancyMoths(int PregnancyMoths) { this.PregnancyMoths = PregnancyMoths; }


        public override string ToString()
        {
            return base.ToString()+$" Mammal-> Milk:{MilkCalories}";
        }

        public new int eat()
        {
            return base.eat()  + this.MilkCalories;
        }
    }
}
