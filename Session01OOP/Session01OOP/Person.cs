using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01OOP
{
    internal struct Person
    {
        //Property
	
        public int Age { set; get; }
        public string Name { set; get; }


        //Function
        public override string ToString()
        {
            return $"Name : {Name} Age : {Age}";
        }
    }
}
