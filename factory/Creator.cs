using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.factory
{
    abstract class Creator
    {
        // Note that the Creator may also provide some default implementation
        
// the factory method.
public abstract IProduct FactoryMethod();
    
public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: le même createur  "
+   product.Operation();
            return result;
        }
    }
    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    class ConcreteCreator1 : Creator
    {
     
    public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
    // The Product interface declares the operations that all concrete
   
// must implement.
public interface IProduct
    {
        string Operation();
    }
    // Concrete Products provide various implementations of the Product
    // interface.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{product 1 TV}";
        }
    }
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Product 2 Smartphone}";
        }
    }
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client:je ne connais pas le créateur de la class,"
            +
            "mais ça fonctionne encore.\n" + creator.SomeOperation());
            // ...
        }
    }
}
