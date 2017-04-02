using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface ILiving
    {
        //! An interface contains only the signatures of METHODS( abstract methods), PROPERTIES (not fields), EVENTS or INDEXERS.
        //! Can add many interfaces to class using implement, but abstract class using 1 only.
        //! Only use PUBLIC, STATIC and FINALS 
        void SetName(string name);
        string GetName();

        void SetWeight(int weight);

        int GetWeight();
    }   
}
