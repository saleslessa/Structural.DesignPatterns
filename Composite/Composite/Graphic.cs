using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Abstract class which provides implementation of composite pattern, because it makes all classes of same type
    /// and recursively used by composite classes
    /// </summary>
    public abstract class Graphic
    {
        protected List<Graphic> listOfGraphics;

        public abstract string Draw();

        public abstract void Add(Graphic g);

        public abstract void Remove(Graphic g);
    }
}
