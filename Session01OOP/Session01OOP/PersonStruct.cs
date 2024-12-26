using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01OOP
{
    internal struct PersonStruct
    {
        //Property 
        public int Age { set; get; }
        public string Name { set; get; }

        //Constructor
        public PersonStruct(int _age , string _name)
        { 
        Age=_age;
        Name = _name;
        }



    }
}
