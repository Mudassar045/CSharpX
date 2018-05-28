using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpXperiments
{
    public static class NamedTuple
    {
        public static void demo()
        {
            var ToString = "This is some text";
            var one = 1;
            var Item1 = 5;
            var projections = (ToString, one, Item1);
            // Accessing the first field:
            Console.WriteLine(projections.Item1);
            // There is no semantic name 'ToString'
            // Accessing the second field:
            Console.WriteLine(projections.one);
            Console.WriteLine(projections.Item2);
            // Accessing the third field:
            Console.WriteLine(projections.Item3);
            // There is no semantic name 'Item1`.

            var pt1 = (X: 3, Y: 0);
            var pt2 = (X: "Pakistan", Y: 4);

            var xCoords = (pt1.X, pt2.X);
            // There are no semantic names for the fields
            // of xCoords. 

            // Accessing the first field:
            Console.WriteLine(xCoords.Item1);
            // Accessing the second field:
            Console.WriteLine(xCoords.Item2);
        }
    }
}
