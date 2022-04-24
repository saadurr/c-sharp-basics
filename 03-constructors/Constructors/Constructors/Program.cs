/*
 * There are four basic types of constructors in C#
 * Default, Parametrized, Static and Private
 * 
 * The default contructor does not take any argument. If its not defined, the compiler provides a default constructor.
 * 
 * Parametrized constructor takes an argument. 
 * 
 * Private constructors are used to limit external instantiation of a class. You cannot directly create an object with this constructor
 * but you can call it in a nested class. used to implement a singleton pattern and was used in C# 1.0 when there was no static constructor.
 * 
 * Static constructors are used for actions that need to be performed only once. A class can have only one static constructors. It cannot be parametrized.
 * it does not have no access modifier.
 */


using System;

namespace Constructors
{
    public class Student 
    { 
        public string name { get; set; }
        public int studentID { get; set; }
        public string collegeName { get; set; }
        private static int totalStudents;


        //Default Constructor
        public Student()
        {
            Console.WriteLine("Default constructor for Student class has been called.\n");
            name = "default name";
            studentID = -1;
            collegeName = "default college";
            totalStudents++;
        }

        //Parametrized Constructor
        public Student(int ID, string name, string cName)
        {
            Console.WriteLine("Parametrized constructor for Student class has been called with the arguments: {0}, {1}, {2} \n", ID, name, cName);

            studentID = ID;
            this.name = name;
            collegeName = cName;
            totalStudents++;
        }

        //Private Constructor with one argument
        private Student(int total)
        {
            totalStudents = total;
        }

        public static int getTotalStudents()
        {
            return totalStudents;
        }

        //This is a nested class to demonstrate that the private constructor will be accessible here
        public class NestedStudent
        {
            public void testFunc()
            {
                Student s3 = new Student(100);

                Console.WriteLine("Total Number of students is: {0}.\n", Student.getTotalStudents());
            }

        }

        ~Student()
        {
            Console.WriteLine("Destructor for Student class has been called.\n");
        }
    }

    public class ClassWithStaticConstructor
    { 
        private static int counter;

        private ClassWithStaticConstructor()
        {
            Console.WriteLine("Called the private constructor.\n");
            counter = 0;
        }

        //static constructor - there can only be one and it must not have any access modifier.
        static ClassWithStaticConstructor()
        {
            Console.WriteLine("Called the static constructor.\n");
            counter = 0;
        }

        public ClassWithStaticConstructor(int icount)
        {
            Console.WriteLine("Called the public constructor.\n");
            counter = icount;
        }

        public void addToCounter()
        {
            counter++;
        }

        public static int getCounter()
        {
            return counter;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //Default CBonstructor test
            Student s1 = new Student();
            Console.WriteLine("Default student object values are: ID is {0}, Name is {1}, and college is {2}.\n", s1.studentID, s1.name, s1.collegeName);

            //Parametrized Constructor test
            Student s2 = new Student(117, "John Doe", "XYZ College");
            Console.WriteLine("Student object values are: ID is {0}, Name is {1}, and college is {2}.\n", s2.studentID, s2.name, s2.collegeName);

            //Private Constructor test - this is not allowed due to protection level of the constructor
            //Student s3 = new Student(100);
            Console.WriteLine("Total Number of students is: {0}.\n", Student.getTotalStudents());

            //Private Constructor test with Nested Class
            Student.NestedStudent n1 = new Student.NestedStudent();
            n1.testFunc();

            //Static Constructor test - the static counter gets called before the public constructor is called.
            ClassWithStaticConstructor c1 = new ClassWithStaticConstructor(1);
            Console.WriteLine("Counter is: {0}.\n", ClassWithStaticConstructor.getCounter());
            
        }
    }
}
