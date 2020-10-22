using System;

namespace polymorphism {
    class Program {
        static void Main (string[] args) {
            int addedSumOfInts = AddTwoInt (7, 13);

            int addedSumOfDoubles = AddTwoDoubles (7.5, 13.8)
            Console.WriteLine ("Int: " + addedSumOfInts);
        }

        static int AddTwoInt (int x, int y) {
            return x + y;

        }

        static double AddTwoDouble (double x, double y) {
            return x + y;
        }
    }
}