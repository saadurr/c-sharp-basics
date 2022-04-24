/*
 * There are four basic types of constructors in C#
 * Default, Parametrized, Static and Private
 * 
 * The default contructor does not take any argument. If its not defined, the compiler provides a default constructor.
 * 
 * Parametrized constructor takes an argument. 
 */


using System;

namespace Constructors
{
    class Student 
    { 
        public string name { get; set; }
        public int studentID { get; set; }
        public string collegeName { get; set; }

        //Default Constructor
        public Student()
        {
            name = "default name";
            studentID = -1;
            collegeName = "default college";
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            //Default constructor test
            Console.WriteLine("Default student object values are: ID is {0}, Name is {1}, and college is {2}", s1.studentID, s1.name, s1.collegeName);
        }
    }
}
