using System;
namespace Decorator.Domain
{
    public abstract class BasePizza
    {
        protected double price;

        public virtual double GetPrice() {
            return price;
        }
    }
}
