using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// Composite Class which implement all methods provided by abstract super class, common among children
    /// </summary>
    public class Picture : Graphic
    {
        
        public Picture()
        {
            listOfGraphics = new List<Graphic>();
        }

        public override void Add(Graphic g) 
        {
            listOfGraphics.Add(g);    
        }

        public override void Remove(Graphic g) 
        {
            listOfGraphics.Remove(g);
        }

        public override string Draw()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in listOfGraphics)
            {
                result.Append(item.Draw());
            }

            return result.ToString();
        }
    }
}
