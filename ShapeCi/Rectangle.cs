using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCi
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;
        public double Width { get { return _width; } set { if (_width > 0) _width = value; else throw new ArgumentException("Ширина должна быть больше 0"); } }
        public double Height { get { return _height; } set { if (_height > 0) _height = value; else throw new ArgumentException("Высота должна быть больше 0"); } }



        public override double Area() // площадь
        {
           
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
        public override string ToString()
        {
            return $"высота: {Height}, длинна: {Width}, площадь: {Area()}, периметр: {Perimeter()}, прямоугольника";
        }


    }
}
