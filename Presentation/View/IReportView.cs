using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public interface IReportView: IView
    {
        void UpdateNumbers(List<Double> numbers);
    }
}
