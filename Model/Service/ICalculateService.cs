using SuperCalculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Service
{
    public interface ICalculateService
    {
        String GetResultNow();
        String CurrentNumber(string number);
        void SetData (List<Double> bigIntegers);
        List<Double> Execute(Operation operation);
    }
}
