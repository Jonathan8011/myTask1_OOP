using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class hoopoe : Bird
    {
        int numOfhoopoe;
        public hoopoe(string name, int age, bool isHunter, int caloris, int flightAltitude, int wingspan, int numOfhoopoe) : base(name, age, isHunter, caloris, flightAltitude, wingspan)
        {
            this.numOfhoopoe = numOfhoopoe;
        }

        public int getnumOfBolBol() { return numOfhoopoe; }
        public void setnumOfBolBol(int numOfBolBol) { this.numOfhoopoe = numOfBolBol; }
    }
}
