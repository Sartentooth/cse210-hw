using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(string color, double radius, string name) : base(color, name){
            _radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * (Math.Pow(_radius, 2));
        }
    }
}