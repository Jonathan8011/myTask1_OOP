using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Animal
    {
        protected string name;
        protected int age;
        protected bool isHunter;
        protected int caloris;

        public Animal(string name, int age, bool isHunter, int caloris)
        {
            this.name = name;
            this.age = age;
            this.isHunter = isHunter;
            this.caloris = caloris;

        }

        public void setName(string name) { this.name = name;}
        public void setAge(int age) {  this.age = age;}
        public void setisHunter(bool isHunter) { this.isHunter = isHunter; }
        public void setcaloris(int caloris) { this.caloris = caloris; }

        public string GetName() { return name; }
        public int GetAge() { return age; }
        public bool GetisHunter() { return isHunter; }
        public int Getcaloris() { return caloris; }

        public override string ToString()
        {
            return $"{name}, age:{age}";
        }

        public int eat()
        {
            return this.caloris * 3;
        }
    }
}
