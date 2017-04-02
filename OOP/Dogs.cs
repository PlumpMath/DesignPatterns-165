using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dogs : Animals
    {
        public void DigHole()
        {
            Console.WriteLine("Dig a Hole.");
        }

        public Dogs() : base()
        {
            Sound = "Gooo go";
        }

        public void RandNumber(int rand)
        {
            rand = 12;

            Console.WriteLine($"Random number in method: {rand}");
        }

        private void BePrivate()
        {
            Console.WriteLine("Dog: Private method.");
        }

        public void AccessPrivate()
        {
            BePrivate();
        }
    }
}
