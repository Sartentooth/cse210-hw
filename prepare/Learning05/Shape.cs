using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public abstract class Shape
    {
        private string _color;
        private string _name; 
        
        public Shape(string color, string name){
            _color = color;
            _name = name;
        }
        public string GetName(){
                return _name;
            }
        public string GetColor(){
            return _color;
        }
        public void SetColor(string color){
            _color = color;
        }
        public abstract double GetArea();
    }
}