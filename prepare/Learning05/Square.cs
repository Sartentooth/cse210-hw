using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Square : Shape
    {
        private double _side;
        public Square(string color, double side, string name) : base(color, name){
            _side = side;
            
        }
        public override double GetArea()
        {
            return _side * _side;
        }
    }
}