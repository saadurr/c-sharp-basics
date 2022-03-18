using System;

namespace Assembly2
{
    public class Assembly2DerviedClass : Assembly1.Assembly1BaseClass
    {
        public void testAccessInDerived()
        {
            //Private and Internal variable is not accessible in derived class
            //Console.WriteLine(privateVariable);
            //Console.WriteLine(internalVariable);

            //All of the following are accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalProtectedVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly2OtherClass
    {
        public void testAccess()
        {
            Assembly1.Assembly1BaseClass A = new Assembly1.Assembly1BaseClass();

            //Console.WriteLine(A.privateVariable);
            //Console.WriteLine(A.protectedVariable);
            //Console.WriteLine(A.internalVariable);
            //Console.WriteLine(A.internalProtectedVariable);

            //Only public are accesible
            Console.WriteLine(A.publicVariable);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Assembly2DerviedClass A1 = new Assembly2DerviedClass();
            A1.testAccessInDerived();

            Console.WriteLine("\n");

            Assembly2OtherClass A2 = new Assembly2OtherClass();
            A2.testAccess();
        }
    }
}
