﻿using System;
namespace Composite
{
    /// <summary>
    /// Leaf class which has no implementation of leaf class management
    /// </summary>
    public class Hey : Graphic
    {
        public override void Add(Graphic g)
        {
            throw new NotImplementedException();
        }

        public override string Draw()
        {
            return "\n \\o/ \n";
        }

        public override void Remove(Graphic g)
        {
            throw new NotImplementedException();
        }
    }
}
