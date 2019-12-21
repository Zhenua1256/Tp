using SuperCalculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class DivisionOperation: Operation
    {
        public DivisionOperation (Double number) : base(number)
        {
        }
        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] /= number;
            }
            return numbers;
        }
    }
}
