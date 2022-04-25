/*
 *
 *Method Overloading is when two functions have same names but different signatures (number or type of parameters are different).
 *Return type or access modifier are not considered part of signature.
 *Method overloading is compile time polymorphism.
 *
 *Method Overriding is when two functions with same names and same signatures occur in a parent-child class pair.
 *it is runtime polymorphism.
 *
 *
 *Method Hiding - doesnt need to use virtual keyword - uses new keyword. Resolved at compile time.
*/
using System;

namespace MethodOverrirdingOverloading
{

    //Example for Method Overloading
    class Calculator
    {
        //The function sum has been overloaded
        public int sum(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int sum(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }

        public double sum(double num1, double num2)
        {
            return (num1 + num2);
        }
    }

    //Example for Method Overriding
    public class Vehicle
    {
        public double price { get; set; }
        
        public Vehicle()
        {
            Console.WriteLine("Vehicle constructor called.\n");
            price = 10000;
        }
        public virtual double getRentalRate()
        {
            return 0.05*price;
        }
    }

    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car constructor called.\n");
        }
        public override double getRentalRate()
        {
            return 0.08 * price;
        }
    }


    //Example for Method Hiding
    public class Employee
    {
        public double salary { get; set; }
        public Employee()
        {
            salary = 1000;
        }
        public double calcSalary()
        {
            return salary;
        }
    }

    public class NewHires : Employee
    {
        public new double calcSalary()
        {
            return 0.85 * salary;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Method Overloading test
            Calculator calc1 = new Calculator();
            var r1 = calc1.sum(1, 2);
            var r2 = calc1.sum(1, 2, 3);
            var r3 = calc1.sum(2.1, 2.3);
            Console.WriteLine("Results are:\n{0}\n{1}\n{2}\n", r1,r2,r3);

            //Method Overriding
            Vehicle v1 = new Vehicle();
            Console.WriteLine("Rental Rate for Vehicle Object is:{0}\n\n ", v1.getRentalRate());
            Car c1 = new Car();
            Console.WriteLine("Rental Rate for Car Object is:{0} \n\n", c1.getRentalRate());

            //If the method is not overriden and marked as virtual, it will call the function from base class.
            Vehicle v2 = new Car();
            Console.WriteLine("Rental Rate for Vehicle Object is:{0} \n\n", v2.getRentalRate());


            //Method Hiding
            Employee e1 = new Employee();
            Console.WriteLine("Employee object salary: {0}\n", e1.calcSalary());

            NewHires nh1 = new NewHires();
            Console.WriteLine("New Hires object salary: {0}\n", nh1.calcSalary());

            Employee e2 = new NewHires();
            Console.WriteLine("Employee object pointing to new hires salary: {0}\n", e2.calcSalary());

        }
    }
}
