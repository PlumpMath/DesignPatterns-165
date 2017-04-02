using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Creature
    {
        //! Cannot have "abstract" fields
        //private string _name;

        //private int _weight;

        //private string _sound;

        //! Expression properties: new features of C# 7.0
        //public string Name { get => _name; set => _name = value; }
        //public int Weight { get => _weight; set => _weight = value; }
        //public string Sound { get => _sound; set => _sound = value; }


        //! Abstract member cannot be private
        public abstract void SetName(string name);
        public abstract string GetName();

        public abstract void SetWeight(int weight);

        public abstract int GetWeight();
    }
}
