using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SuperCalculator.Model
{
    public class SumOperation : Operation
    {
        public SumOperation(Double number) : base(number)
        {
        }

        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] += number;
            }
            return numbers;
        }
    }
}