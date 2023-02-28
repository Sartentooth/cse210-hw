using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Rectangle : Shape
    {
        private double _sideH;
        private double _sideW;
        public Rectangle(string color, double sideH, double sideW, string name) : base(color, name){
            _sideH = sideH;
            _sideW = sideW;
        }
        public override double GetArea()
        {
            return _sideH * _sideW;
        }
    }
}