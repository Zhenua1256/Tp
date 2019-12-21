using System;
using System.Collections.Generic;
using System.Numerics;

namespace SuperCalculator.Model
{
    public abstract class Operation
    {
        public Double number;

        protected Operation(Double number)
        {
            this.number = number;
        }

        protected Operation()
        {
        }

        public abstract List<Double> execute(ref List<Double> numbers);
    }
}