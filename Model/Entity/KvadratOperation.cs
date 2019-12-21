using SuperCalculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class KvadratOperation: Operation
    {
        public KvadratOperation() 
        {
        }
        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= numbers[i];
            }
            return numbers;
        }
    }
}
