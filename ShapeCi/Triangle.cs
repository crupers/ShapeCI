using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCi
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public double SideA { get {  return _sideA; } set { if(value > 0) _sideA = value; else throw new ArgumentException("Эта сторона должна быть больше 0"); } }
        public double SideB { get { return _sideB; } set { if (value > 0) _sideB = value; else throw new ArgumentException("Эта сторона должна быть больше 0"); } }
        public double SideC { get { return _sideC; } set { if (value > 0) _sideC = value; else throw new ArgumentException("Эта сторона должна быть больше 0"); } }
        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
        public override double Area()
        {
            double p = Perimeter() / 2; 
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override string ToString()
        {
            return $"Сторона а: {SideA},Сторона b: {SideB},Сторона c: {SideC}, Площадь = {Area()}, Периметр = {Perimeter()}";
        }

    }
}
