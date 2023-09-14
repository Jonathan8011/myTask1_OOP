using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_
{
    internal class Bird : Animal
    {
        protected int flightAltitude;
        protected int wingspan;
        public Bird(string name, int age, bool isHunter, int caloris, int flightAltitude, int wingspan) : base(name, age, isHunter, caloris)
        {
            this.flightAltitude = flightAltitude;
            this.wingspan = wingspan;
        }


        public int getflightAltitude() { return flightAltitude; }
        public void setflightAltitude(int flightAltitude) { this.flightAltitude = flightAltitude; }

        public int getwingspan() { return wingspan; }
        public void setwingspan(int wingspan) { this.wingspan = wingspan; }

        public static string  Sing()
        {
            return "I went out to the forest,\r\nI found a flock of birds there,\r\na crowd of birds, big and small,\r\nAll together a song of gifts.\r\nOne opened and said: My mouth!\r\nThey all answered: Mouth, mouth, mouth!\r\nThe praise of my Lord will speak through me!";
        }
        public void Dance() { Console.WriteLine("ƪ(˘⌣˘)ʃ (❁´◡`❁) q(≧▽≦q) "); }
    }
}
