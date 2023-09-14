using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Snake : Reptile
    {
        protected bool Poisonous;
        public Snake(string name, int age, bool isHunter, int caloris, int tailLength, bool poisonous) : base(name, age, isHunter, caloris, tailLength)
        {
            Poisonous = poisonous;
        }

        public bool getPoisonous() { return Poisonous; }
        public void setPoisonous(bool Poisonous) { this.Poisonous = Poisonous; }

        public void Dance() { Console.WriteLine("ƪ(˘⌣˘)ʃ (❁´◡`❁) q(≧▽≦q)"); }
    }
}
