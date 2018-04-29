using System;
using Decorator.Decorator;

namespace Decorator.Domain
{
    public class ExtraCheeseTopping : ToppingsDecorator
    {
        public ExtraCheeseTopping(BasePizza pizzaToDecorate)
            :base(pizzaToDecorate)
        {
            price = 0.99;
        }
    }
}
