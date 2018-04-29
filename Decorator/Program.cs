using System;
using Decorator.Domain;

namespace Decorator
{
    /// <summary>
    /// Example of code using Decorator pattern
    /// References: 
    /// - GAMMA, E.; HELM, R. JOHNSON, R.; VLISSIDES, J. Design Patterns. Bookman Ed.
    /// - https://stackoverflow.com/questions/2707401/understand-the-decorator-pattern-with-a-real-world-example
    /// - https://blogs.msdn.microsoft.com/rajakedar_ganta/2013/10/16/extension-pattern-in-net-decorate-the-class-with-attributes/
    /// - https://www.devmedia.com.br/um-pattern-em-c-por-dia-decorator-pattern-estrutural/21747
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new Margherita();
            Console.WriteLine("Plain Margherita: " + pizza.GetPrice().ToString());

            var moreCheese = new ExtraCheeseTopping(pizza);
            var someMoreCheese = new ExtraCheeseTopping(moreCheese);
            Console.WriteLine("Plain Margherita with double extra cheese: " + someMoreCheese.GetPrice().ToString());

            var moreMushroom = new MushroomTopping(someMoreCheese);
            Console.WriteLine("Plain Margherita with double extra cheese with mushroom: " + moreMushroom.GetPrice().ToString());

            var moreJalapeno = new JalapenoTopping(moreMushroom);
            Console.WriteLine("Plain Margherita with double extra cheese with mushroom with Jalapeno: " + moreJalapeno.GetPrice().ToString());

            Console.ReadLine();
        }
    }
}
