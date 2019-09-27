using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolyMorphism
{
    abstract class Shape
    {
        public string Color { get;  set; }
        public int HeightOrRadius { get;  set; }


       public Shape(string Color, int HOR)
        {
            this.Color = Color;
            this.HeightOrRadius = HOR;

        }

        virtual public int Area()
        {
            return 1;
        }
        virtual public int Area(int OtherSide)
        {
            return 1;
        }

    }
}
