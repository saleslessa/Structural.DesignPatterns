using System;
namespace Composite
{
    /// <summary>
    /// Leaf class which has no implementation of leaf class management
    /// </summary>
    public class Text : Graphic
    {
        private readonly string value;

        public Text(string val)
        {
            value = val;
        }

        public override void Add(Graphic g)
        {
            throw new NotImplementedException();
        }

        public override string Draw()
        {
            return value;
        }

        public override void Remove(Graphic g)
        {
            throw new NotImplementedException();
        }
    }
}
