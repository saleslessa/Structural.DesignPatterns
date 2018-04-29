using Decorator.Domain;

namespace Decorator.Decorator
{
    public abstract class ToppingsDecorator : BasePizza
    {
        protected BasePizza pizza;

        public ToppingsDecorator(BasePizza pizzaToDecorate)
        {
            pizza = pizzaToDecorate;
        }

		public override double GetPrice()
		{
            return pizza.GetPrice() + price;
		}
	}
}
