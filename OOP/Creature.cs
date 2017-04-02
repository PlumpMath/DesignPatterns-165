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
        string _name 

        int _weight;

        string _sound;


        //! Abstract member cannot be private
        public abstract void SetName(string name);
        public abstract string GetName();

        public abstract void SetWeight(int weight);

        public abstract int GetWeight();
    }
}
