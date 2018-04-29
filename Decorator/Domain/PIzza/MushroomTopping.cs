using System;
using Decorator.Decorator;

namespace Decorator.Domain
{
    public class MushroomTopping : ToppingsDecorator
    {
        public MushroomTopping(BasePizza pizzaToDecorate)
            :base(pizzaToDecorate)
        {
            price = 1.49;
        }
    }
}
