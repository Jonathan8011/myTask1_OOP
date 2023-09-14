using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class snakeSeveralHeaded : Snake
    {
        protected int numHead;
        public snakeSeveralHeaded(string name, int age, bool isHunter, int caloris, int tailLength, bool poisonous, int numHead) : base(name, age, isHunter, caloris, tailLength, poisonous)
        {
            this.numHead = numHead;
        }

        public int getnumHead() { return numHead; }
        public void setnumHead(int numHead) { this.numHead = numHead; }
    }
}
