using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2_OOP
{
    class Shape
    {
        private String color = "red";
        private bool filled = true;

         Shape() { }
        Shape(string Color, bool Filled)
        {
            this.color = Color;
            this.filled = Filled;
        }

        public String getColor()
        {
            return color;
        }
        public bool get

        public virtual void DisplayInfo()
        {
            Console.WriteLine("the color of the shape is"+);

        }



    }
}
