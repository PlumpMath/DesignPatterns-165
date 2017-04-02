using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animals
    {
        private string _name;

        private string _sound;

        private int _weight;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > _weight)
                {
                    _weight = value;
                }
                else
                {
                    Console.WriteLine("New value must greater than old value.");
                }
            }
        }

        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }
    }
}
