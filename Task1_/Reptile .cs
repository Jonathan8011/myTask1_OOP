using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Reptile : Animal
    {
        protected int tailLength;
        public Reptile(string name, int age, bool isHunter, int caloris, int tailLength) : base(name, age, isHunter, caloris)
        {
            this.tailLength = tailLength;
        }

        public int gettailLength() { return tailLength; }
        public void settailLength(int tailLength) {this.tailLength = tailLength; }
    }
}
