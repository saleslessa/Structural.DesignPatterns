using System;

namespace Adapter
{
    /// <summary>
    /// Example of code using Adapter pattern
    /// References: 
    /// - GAMMA, E.; HELM, R. JOHNSON, R.; VLISSIDES, J. Design Patterns. Bookman Ed.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create adapter and place a request
            var target = new Adapter();
            target.Request();

            Console.ReadKey();
        }
    }
}
