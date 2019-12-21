using Model.Service;
using Ninject;
using Presentation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenters
{
    public class ReportPresenter
    {
        protected IKernel _kernel { get; set; }
        protected ICalculateService _calculateService { get; set; }
        protected ICalculatorView _view { get; set; }
        protected IReportView _viewReport { get; set; }

        public ReportPresenter(IKernel kernel, ICalculateService calculateService, ICalculatorView view, IReportView viewReport)
        {
            _kernel = kernel;
            _calculateService = calculateService;
            _view = view;
            _viewReport = viewReport;
        }
       
        public void UpdateNumbers(List<Double> numbers)
        {
            _viewReport.UpdateNumbers(numbers);
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
