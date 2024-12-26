using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Session01OOP
{

    //Enum

    enum Grades
    {
        A = 1, B, C, D, F
    }


    //Enum 1 Assignment WeekDays

    enum WeekDays
    {

        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }


    //Enum 3 

    enum Season
    {

        Spring, Summer, Autumn, Winter
    }


    //Enum 5
    enum Colers
    {
        red,green,blue , Red, Green, Blue
    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bism Allh El Rhman El Rahym");


            #region Session 1 oop
            #region Enum 
            ////1-Value Type  
            ///2-User Define
            ///3-Write In Name Space



            Grades grades = new Grades();


            // Console.WriteLine(Grades.A);//A
            //do
            //{
            //    Console.WriteLine("Enter  Degree : ");
            //    int degree = int.Parse(Console.ReadLine());

            //    if (degree >= 90)
            //    {
            //        grades = Grades.A;
            //        Console.WriteLine(grades);
            //    }
            //    else if (degree>= 80)
            //    { 
            //    grades=Grades.B;    
            //        Console.WriteLine(grades);  
            //    }
            //}

            //while (true);


            #endregion
            #region Struct
            //// Struct Value Type 
            ///2-Not Support Inheritance
            ///3-Not Support Overloading
            ///4-Support Interface 
            ///******when you Create Constructor The Defualt Constructor Not Delete
            ///Fast And Good Foe Small Data
            ///

            //Point point = new Point();
            //point.X = 10;
            //Console.WriteLine(point); //x = 10 , y = 0

            //Point point1 = new Point(100, 200);
            //Console.WriteLine(point1);//x=100 , y=200

            #endregion
            #region Encapsulation 
            Employee emp = new Employee(10, "Mohamed helmy", 12_500);
            //Console.WriteLine(emp);//Print Direct Defualt .ToString()

            //emp.SetName("Mohamed");
            //Console.WriteLine(emp.GetName()); //Moham  Because Validation 

            ////Property
            //emp.Id = 1;//Property Not Attributes
            //Console.WriteLine(emp.Id);//1














            #endregion

            #endregion

            #region Assignment 5


            #region Q1

            // 1 - Create an enum called "WeekDays" with the days of the week(Monday to Sunday)
            // as its members.Then, write a C# program that prints out all the days of the week using this enum.
            //=============================Solution==========================================


            //WeekDays weekDays1  = new WeekDays();

            //foreach (WeekDays d in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(d);
            //}

            #endregion
            #region Q2
            // 2.Define a struct "Person" with properties "Name" and "Age".
            // Create an array of three "Person" objects and populate it with data.Then,
            // write a C# program to display the details of all the persons in the array.
            //=============================Solution==========================================


            //  1 

            //Person[]ArrayOfStructPerson=new Person[3];
            //ArrayOfStructPerson[0] = new Person() {Age=10,Name="mohamed" };
            //ArrayOfStructPerson[1] = new Person() { Age = 20, Name = "ali" };
            //ArrayOfStructPerson[2] = new Person() { Age = 30 , Name = "saad" };
            //foreach (Person person in ArrayOfStructPerson)
            //{
            //    Console.WriteLine($"Name :  {person.Name} Age : {person.Age}");
            //}


            //  2  حل اخر

            //Person person1 = new Person();
            //person1.Name = "ali";
            //person1.Age = 20;

            //Person person2 = new Person();
            //person1.Name = "saad";
            //person1.Age = 30;

            //Person person3 = new Person();
            //person1.Name = "mohamed";
            //person1.Age = 21;


            //Person[] Array = { person1, person2, person3 };
            //foreach (Person p in Array)
            //{
            //    Console.WriteLine(p.ToString());
            //}































            #endregion
            #region Q3

            //  3.Create an enum called "Season"
            //  with the four seasons(Spring, Summer, Autumn, Winter)
            //  as its members.Write a C# program that takes a season name
            //  as input from the user and displays the corresponding month range
            //  for that season. Note range for seasons
            //  ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //=============================Solution==========================================
            //string Action;


            //Season s = new Season();



            //do
            //{

            //    Console.Write("Enter Season [Spring, Summer, Autumn, Winter] : ");
            //    string SeasonInput = Console.ReadLine();

            //    bool flag = Enum.TryParse(SeasonInput, out s);
            //    if (flag == true)
            //    {

            //        switch (s)
            //        {
            //            case Season.Spring:
            //                Console.WriteLine("Spring=> March, April, May");
            //                break;

            //            case Season.Summer:
            //                Console.WriteLine("June, July, August");
            //                break;

            //            case Season.Autumn:
            //                Console.WriteLine("September, October, November");
            //                break;

            //            case Season.Winter:
            //                Console.WriteLine("December, January, February");
            //                break;


            //        }




            //    }
            //    else
            //    {
            //        Console.WriteLine("Error Happen");
            //    }





            //    Console.WriteLine("Continue : c  , Exit : x : ");
            //    Action = Console.ReadLine();

            //} while (Action != "x");



























            #endregion////////////
            #region Q4 XXXXXX
            #endregion
            #region Q5
            // 5.Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            // as its members.Write a C# program that takes a color name as input from
            // the user and displays a message indicating whether the input color is a primary color or not.
            //=============================Solution==========================================

            //  Colers colers = new Colers();   
            //  Console.Write("Enter Colere : ");
            //  string ColorInput=Console.ReadLine();


            //bool flag=  Enum.TryParse(ColorInput, out colers);
            //  if (flag == true)
            //  {

            //      switch (colers)
            //      { 
            //      case Colers.red:
            //      case Colers.green:
            //      case Colers.blue :
            //      case Colers.Red:
            //      case Colers.Green:
            //      case Colers.Blue:
            //          Console.WriteLine($"{colers} is a primary color ");
            //              break;
            //          default:
            //              Console.WriteLine($"{colers} is not primary color ");
            //              break;


            //      }


            //  }
            //  else
            //  {
            //      Console.WriteLine("Error Occur ");
            //  }



            #endregion
            #region Q6
            //6.Create a struct called "Point" to represent a 2D point
            //with properties "X" and "Y". Write a C# program that takes
            //two points as input from the user and calculates the distance between them.
            //=============================Solution==========================================

            //PointTask p = new PointTask(4, 6, 1, 2);
            //p.Distance();

            ////Point1(4, 6) , Point2(1, 2)
            ////Distance is : 5








            #endregion
            #region Q7
            // 7.Create a struct called "Person" with properties "Name" and "Age".
            // Write a C# program that takes details of 3 persons as input from the user
            // and displays the name and age of the oldest person.
            //=============================Solution==========================================


            //Console.WriteLine("___________________________________");
            //PersonStruct[] Array = new PersonStruct[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Enter Name OF person Number ({i + 1}) : ");
            //    string name = Console.ReadLine();
            //    Console.Write($"Enter Age : ");
            //    int age = int.Parse(Console.ReadLine());
            //    Array[i] = new PersonStruct(age, name);
            //    Console.WriteLine("_________________________________");
            //}
            //int MaxAge = 0;
            //string NameOfOldMan=" ";
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    if (Array[i].Age >= MaxAge)
            //    {
            //        MaxAge = Array[i].Age;
            //        NameOfOldMan= Array[i].Name;    
            //    }

            //}
            //Console.WriteLine($"Age Of Oldest Man is : {MaxAge}  Name Is : {NameOfOldMan}");


            #endregion


            #endregion





        }

    }

}