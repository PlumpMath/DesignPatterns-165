using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //!? Polymorphism

            Animals dog = new Dogs();
            Animals kitty = new Cats();

            Console.WriteLine(dog.Sound);
            Console.WriteLine(kitty.Sound);


            //! Can put diffirent subclasses in one array
            Animals[] array = new Animals[] {
                dog,
                kitty
            };

            //! you cannot access method by this way.
            //x dog.DigHole();

            ((Dogs)dog).DigHole();

            //! Access private method
            Dogs doggy = new Dogs();
            // Cannot acces private method from others class
            //x doggy.BePrivate()

            doggy.AccessPrivate();

            //!? ABSTRACT
            // Cannot create instance of abstract class or interface
            //x var creature = new Creature();

            Giraffe giraffe = new Giraffe();
            giraffe.SetName("Command");

            Console.WriteLine(giraffe.GetName());

            //!? INTERFACE
            // Cannot create instance of abstract class or interface
            //x ILiving living = new ILiving();

            // Declare an interface instance.
            ILiving living = new Monkey();
           
            //! waiting users input some key
            Console.ReadKey();
        }
    }
}
