using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] ARRmammals = new Animal[5];
            ARRmammals[0] = new Mammal("nati", 15, true, 550, 1500, 5);
            ARRmammals[1] = new Cow("Natn", 55, true, 2, 1, 50, 66);
            ARRmammals[2] = new Cow("kiril", 55, false, 2, 1, 50, 66);
            ARRmammals[3] = new Hipo("miiiii", 55, true, 2, 1, 50, 66);
            ARRmammals[4] = new Hipo("HipoDipo", 55, true, 2, 1, 50, 66);


        }
        public static int caloris(Animal[] animals)
        {
            int sum = 0;
            foreach (var animal in animals)
            {
                sum +=animal.Getcaloris();
            }
            return sum;
        }

        public static int countMammals(Animal[] animals)
        {
            int count = 0;
            foreach (var animal in animals)
            {
                if (animal is Mammal)
                    count++;
            }
            return count;
        }

        public static int Dance(Animal[] animals)
        {
            int count = 0;
            foreach (var animal in animals)
            {
                if (animal is Snake)
                    ((Snake) animal).Dance();
                if(animal is Bird)
                    (animal as Bird).Dance();
            }
            return count;
        }
    }
}
