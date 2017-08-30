using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHP10PE03
{
    class Rectangle
    {
        private double length;
        private double width;
        private readonly double PERIMETER;
        private readonly double AREA;

        public Rectangle(double length = 1, double width = 1)
        {
            setRectangle(length, width);
            PERIMETER = 2 * (length + width);
            AREA = length * width;
        }

        public Rectangle(Rectangle rectangle) : this(rectangle.length, rectangle.width) { }

        public double Length
        {
            get => length;
            set
            {
                if (value > 0.0 & value < 20.0)
                    length = value;
                else
                    throw new ArgumentOutOfRangeException("Length must be greater than 0 and less than 20: " + value);                
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (value > 0.0 & value < 20.0)
                    width = value;
                else
                    throw new ArgumentOutOfRangeException("Width must be greater than 0");
            }
        }

        private void setRectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Perimeter => PERIMETER;
        public double Area => AREA;

        public override string ToString()
        {
            return ("Length: " + Length +
                "\nWidth: " + Width +
                "\nArea: " + Area +
                "\nPerimeter: " + Perimeter);
        }
    }
}
