using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01OOP
{
    internal struct Point
    {
        //Proparty , Attributes
        public int X; // Defualt Private
        public int Y;
        //Constructor
        public Point(int _X,int _Y)
        { 
           X = _X;  
           Y = _Y; 
        }
        //Methods
        public  override string ToString()
        {
            return $"x={X} , y={Y}";
        }




    }
}
