using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWidthCalculations
{
    class Program
    {
        const int Iterations = 10000000;
        const int Value = 1000000;

        static void Main(string[] args)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            System.Threading.Thread.Sleep(500);
            int bitWidth = 0;

            while (true)
            {
                // METHOD 1
                stopwatch.Restart();
                for (int i = 0; i < Iterations; ++i)
                {
                    bitWidth = CalculateBitWidthMethod1(Value);
                }
                stopwatch.Stop();
                Console.WriteLine("Method 1: " + stopwatch.ElapsedMilliseconds + "  Bit width: " + bitWidth);


                // METHOD 2
                stopwatch.Restart();
                for (int i = 0; i < Iterations; ++i)
                {
                    bitWidth = CalculateBitWidthMethod2(Value);
                }
                stopwatch.Stop();
                Console.WriteLine("Method 2: " + stopwatch.ElapsedMilliseconds + "  Bit width: " + bitWidth);
            }
        }

        public static int CalculateBitWidthMethod1(int value)
        {
            int bitWidth = (int)Math.Ceiling(Math.Log(value, 2));
            return bitWidth;
        }

        public static int CalculateBitWidthMethod2(int value)
        {
            int bitWidth = 1;
            while ((value >>= 1) > 0)
            {
                bitWidth++;
            }
            return bitWidth;
        }

    }
    
}
