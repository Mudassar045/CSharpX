using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpXperiments
{
    public static class NonTrailingNamedArgs
    {
        public static void showVolume()
        {

            var v1 = getVolume(a: 3, c: 5, b: 4);
            var v2 = getVolume(a: 3, 4, 5);
            var v3 = getVolume(3, b: 4, 5);
            var v4 = getVolume(3, 4, c: 5);

            Console.WriteLine($" Volume is: {v1}");
            Console.WriteLine($" Volume is: {v2}");
            Console.WriteLine($" Volume is: {v3}");
            Console.WriteLine($" Volume is: {v4}");
        }
        public static Int32 getVolume(int a, int b, int c)
        {
            return (a * b * c);
        }
    }
}
