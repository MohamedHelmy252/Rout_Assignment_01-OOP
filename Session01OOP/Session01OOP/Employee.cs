using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01OOP
{
    internal class Employee
    {


        //Class When You Create Constructor Take Parameter 
        //=> The Defualt Constructor (Deleted)

        //Struct When You Create Constructor Take Parameter 
        //=> The Defualt Constructor (Not Deleted)

        #region Attributes
        private int id;
        public string Name;
        public decimal Salary;
        #endregion

        #region Constructors 
        public Employee(int _Id ,string _Name , Decimal _Salary)
        { 
            Id = _Id ;  
            Name = _Name ;  
            Salary = _Salary ;  
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"id={Id}\name={Name}\nsalary={Salary}";
        }
        #endregion


        #region Encapsulation 
        //Encapsulation : Separate Data Defination[Attributes]
        //From It Use  By [Getter , Setter , Property , Indexer]


        #region Getter & Setter  
        //Getter 
        public string GetName()
        {
            return Name;
        }

        //Setter    اقدر اعمل validation 
        public void SetName(String _Name)
        { 
            // this.Name = _Name ; 

            //Validation Name Input = 5 Character
             this.Name = _Name.Length<=5?_Name: _Name.Substring(0,5);  
        }

        #endregion

        #region Propertey

        //Property  
        //Attributes Must Be Private 
        //Make Id is : id

        //1.1 Full Property =>Use When You Want To MAke Validation 
        public int Id
        {
            get { return id; }
            set { id = value >= 10 ? value : 10; } 
        }

        //1.2 Automatic Property
        // propfull + Tab
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        #endregion

        #endregion








    }
}
