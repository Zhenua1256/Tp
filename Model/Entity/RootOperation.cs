using SuperCalculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class RootOperation: Operation
    {
        public RootOperation ()
        {
        }
        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = Math.Sqrt(numbers[i]);
            }
            return numbers;
        }
    }
}
