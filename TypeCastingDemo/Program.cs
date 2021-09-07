using System;

namespace TypeCastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Typecast obj = new Typecast();
            obj.dooperation();
            //Console.WriteLine("Hello World!");
        }
    }


    public class Typecast
    {

        public void dooperation()
        {
            int i = 12;
            double d = 678.19;
            int j = (int)d;
            float f = 56.123F;

            int value1 = 656;
            int value2 = 678;
            long sum;
            sum = value1 + value2;

            Console.WriteLine("******Conversion of Double to Int***********");
            Console.WriteLine("******This is Explicit Conversion ***********");
            Console.WriteLine("Value of  i is :"+j);
            Console.WriteLine(Convert.ToString(f));
            Console.WriteLine(Convert.ToUInt32(f));
            Console.WriteLine(Convert.ToDouble(i));

            Console.WriteLine("******Implicit Conversion ***********");
            Console.WriteLine("Sum is :"+ sum);
            Console.WriteLine("We do not lose any data. This type of conversion is known as implicit conversion.");





        }
    
    }
}
