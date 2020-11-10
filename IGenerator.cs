using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
    interface IGenerator
    {
    public int Generate(int[] numbers, float[] probabilities);

    }
}
