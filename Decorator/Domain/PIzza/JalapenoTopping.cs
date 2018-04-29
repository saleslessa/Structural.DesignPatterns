using System;
using Decorator.Decorator;

namespace Decorator.Domain
{
    public class JalapenoTopping : ToppingsDecorator
    {
        public JalapenoTopping(BasePizza pizzaToDecorate)
            :base(pizzaToDecorate)
        {
            price = 1.49;
        }
    }
}
