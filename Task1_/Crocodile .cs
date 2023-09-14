using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Crocodile : Reptile
    {
        protected bool DentalCare;
        public Crocodile(string name, int age, bool isHunter, int caloris, int tailLength, bool dentalCare) : base(name, age, isHunter, caloris, tailLength)
        {
            DentalCare = dentalCare;
        }

        public bool getDentalCare() { return DentalCare; }
        public void setDentalCare(bool DentalCare) { this.DentalCare = DentalCare; }

    }
}
