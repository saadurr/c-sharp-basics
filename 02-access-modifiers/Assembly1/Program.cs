using System;

namespace Assembly1
{
    public class Assembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        internal protected string internalProtectedVariable = "internal + protected";
        public string publicVariable = "public";

        public void testAccess()
        {
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(internalProtectedVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly1DerivedClass : Assembly1BaseClass
    {
        public void testAccessInDerived()
        {
            //Private variable is not accessible in derived class
            //Console.WriteLine(privateVariable);

            //All of the following are accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(internalProtectedVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly1OtherClass
    {
        public void testAccess()
        {
            Assembly1BaseClass A = new Assembly1BaseClass();

            //Private and Protected are not available in other classes
            //Console.WriteLine(A.privateVariable);
            //Console.WriteLine(A.protectedVariable);


            //All of the following are accessible
            Console.WriteLine(A.internalVariable);
            Console.WriteLine(A.internalProtectedVariable);
            Console.WriteLine(A.publicVariable);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Assembly1BaseClass A1 = new Assembly1BaseClass();
            A1.testAccess();

            Console.WriteLine("\n");
            
            Assembly1DerivedClass A2 = new Assembly1DerivedClass();
            A2.testAccessInDerived();

            Console.WriteLine("\n");

            Assembly1OtherClass A3 = new Assembly1OtherClass();
            A3.testAccess();
        }
    }
}
