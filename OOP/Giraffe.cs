using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Giraffe : Creature
    {
        private string _name;
        private int _weight;

        public override string GetName()
        {
            return _name;
        }

        public override int GetWeight()
        {
            return _weight;
        }

        public override void SetName(string name)
        {
            _name = name;
        }

        public override void SetWeight(int weight)
        {
            _weight = weight;
        }
    }
}
