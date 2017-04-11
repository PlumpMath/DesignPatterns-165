using System;

namespace FactoryPattern
{
    //!? Defination
    //! Define an interface for creating an object, but let subclasses decide which class to instantiate. 
    //! Factory Method lets a class defer instantiation to subclasses.
    class Program
    {
        //!? Participants
        //! The classes and objects participating in this pattern are:

        //! Product(Page)
        //defines the interface of objects the factory method creates

        //! ConcreteProduct(SkillsPage, EducationPage, ExperiencePage)
        //implements the Product interface

        //! Creator  (Document)
        //declares the factory method, which returns an object of type Product.Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
        //may call the factory method to create a Product object.

        //! ConcreteCreator(Report, Resume)
        //overrides the factory method to return an instance of a ConcreteProduct.

        static void Main(string[] args)
        {
            Creator[] creator = new Creator[2];
            creator[0] = new ConCreteCreatorA();
            creator[1] = new ConCreteCreatorB();
            foreach (var item in creator)
            {
                var product = item.FactoryMethod();
                Console.WriteLine(product.GetType().Name);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// The 'Product' abstract class
        /// </summary>
        abstract class Product
        {

        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        class ConCreteProductA : Product { }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        class ConCreteProductB : Product { }

        /// <summary>
        /// The 'Creator' abstract class
        /// </summary>
        abstract class Creator
        {
            public abstract Product FactoryMethod();
        }

        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>
        class ConCreteCreatorA : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConCreteProductA();
            }
        }

        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>
        class ConCreteCreatorB : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConCreteProductB();
            }
        }
    }
}
