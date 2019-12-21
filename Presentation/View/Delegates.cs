using SuperCalculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class Delegates
    {
        public delegate void SetData1(List<Double> numbers);
        public delegate void OperationExecuteDelegate(Operation operation);
    }
}
