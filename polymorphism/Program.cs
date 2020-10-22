using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSumOfInts = AddTwoInt(7,13);
            Console.WriteLine("Int: " + addedSumOfInts);
        }

        static int AddTwoInt(int x, int y)
        {
            return x + y;


        }
    }
}
