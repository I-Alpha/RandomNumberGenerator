using System;
using System.Collections.Generic;

namespace RandomGenerator
{
    public class RandomGen : IGenerator
    {

        public int Generate(int[] numbers, float[] probabilities)
        {
            var probSum = new float();
            var len = numbers.Length;
            Dictionary<int, float> freq = new Dictionary<int, float>();
            for (var v = 0; v < len; v++)
            {
                var prob = probabilities[v];
                freq[numbers[v]] = prob;
                probSum += prob;
            };

            var randobj = new Random();
            double dblnum = randobj.NextDouble();
            double ratio = 1.0f / probSum;
            double threshh = 0;

            foreach (var keyValuePair in freq)
            {
                threshh += keyValuePair.Value;
                if (dblnum / ratio <= threshh) return keyValuePair.Key;
            }
            return 0;
        }
        static public Dictionary<int, int> getFreqTable(int iters, int[] numbers, float[] probs)
        {

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (var item in numbers)
            {
                freq[item] = 0;
            }
         
            for (var i = 0; i<iters; i++)
            {
                freq[new RandomGen().Generate(numbers, probs)]++;
            }
            return freq;
        }
   }
}
