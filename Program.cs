using System;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitEx1

{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Task<int> result1 = LongProcess1();
            Task<int> result2 = LongProcess2();

            ShortProcess();
            Console.WriteLine("After 2 long process");

            int val = await result1;
            DisplayResult(val);

            val = await result2;
            DisplayResult(val);
        }

        private static async Task<int> LongProcess1()
        {
            Console.WriteLine("LongProcess1 Started");

            await Task.Delay(4000);

            Console.WriteLine("LongProcess1 Completed");

            return 10;
        }

        private static async Task<int> LongProcess2()
        {
            Console.WriteLine("LongProcess2 Started");

            await Task.Delay(4000);

            Console.WriteLine("LongProcess2 Completed");

            return 20;
        }

        private static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            Console.WriteLine("ShortProcess Completed");
        }

        private static void DisplayResult(int value)
        {
            Console.WriteLine(value);
        }
    }
}