using System;
namespace Adapter
{
    public class Adapter : Target
    {
        readonly Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }
}
