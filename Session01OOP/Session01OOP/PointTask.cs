using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01OOP
{
    internal struct PointTask
    {
        //Attributes 
        private double X0;
        private double Y0;

        private double X1;
        private double Y1;

        //Constructor
        public PointTask(double _X0 , double _Y0 , double _X1, double _Y1)
        { 
            X0 = _X0;   
            Y0 = _Y0;
            X1 = _X1;
            Y1 = _Y1;
        }

        //Method 
        public void Distance()
        {
            double Result = ((Y1 - Y0) * (Y1 - Y0)) + ((X1 - X0) * (X1 - X0));
            
            Console.WriteLine($"Point1({X0} , {Y0} ) , Point2 ({X1} , {Y1})\n Distance is : {Math.Sqrt(Result)}  ");


        }

    }
}
