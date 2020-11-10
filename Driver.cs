using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
    class Driver
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, 0, 1, 2, 3 };
            float[] probs = { 0.01f, 0.3f, 0.58f, 0.1f, 0.01f };
            IGenerator robj = new RandomGen();

            var iter = 10; 
            Dictionary<int, int> freq = new Dictionary<int, int>();   
            var res = (RandomGen.getFreqTable(iter, numbers, probs)); var sum = 0;
            foreach (var pair in res) {
                Console.WriteLine("Key : " + pair.Key + " val:" + pair.Value);
                sum += pair.Value; 
                    }
            Console.WriteLine("\nNumber of interations : " + iter);
            Console.WriteLine("\nTotal distribution : " + sum);
            if(iter==sum)
                Console.WriteLine("\nCode is working");
        }

    }
}
