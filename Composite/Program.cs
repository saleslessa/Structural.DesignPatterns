using System;

namespace Composite
{
    /// <summary>
    /// Example of code using Composite pattern
    /// References: 
    /// - GAMMA, E.; HELM, R. JOHNSON, R.; VLISSIDES, J. Design Patterns. Bookman Ed.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var vertical = new VerticalLine();
            var horizontal = new HorizontalLine();
            var text = new Text("Hello World! I am building a application using Composite Pattern");
            var hey = new Hey();

            var pic = new Picture();
            pic.Add(horizontal);
            pic.Add(vertical);
            pic.Add(text);
            pic.Add(vertical);
            pic.Add(hey);
            pic.Add(hey);
            pic.Add(hey);
            pic.Add(horizontal);

            Console.WriteLine(pic.Draw());
        }
    }
}
