using System;
using System.Collections.Generic;
using System.Text;
using Model.Service;
using Ninject;
using Presentation.View;
using SuperCalculator.Model;

namespace Presentation.Presenters
{
    public class CalculatorPresenter
    {
        protected IKernel _kernel { get; set; }
        protected ICalculateService _calculateService { get; set; }
        protected ICalculatorView _view { get; set; }
        protected IReportView _viewReport { get; set; }

        public CalculatorPresenter(IKernel kernel, ICalculateService calculateService, ICalculatorView view, IReportView viewReport)
        {
            _kernel = kernel;
            _calculateService = calculateService;
            _view = view;
            _viewReport = viewReport;

            _view.ClickOne += ClickOne;
            _view.ClickTwo += ClickTwo;
            _view.ClickThree += ClickThree;
            _view.ClickFour += ClickFour;
            _view.ClickFive += ClickFive;
            _view.OperationExecuteEvent += ExecuteOperationExecute;
            _view.ClickSix += ClickSix;
            _view.ClickSeven += ClickSeven;
            _view.ClickEight += ClickEight;
            _view.ClickNine += ClickNine;
            _view.SetData += SetData1;
            _view.ClickZero += ClickZero;
            _view.ClickBlank += ClickBlank;
           
        }

       

        private void ClickBlank()
        {
            string blank = _view.Blank;
            _calculateService.CurrentNumber(blank);
            ShowInfo();
        }

        private void SetData1(List<Double> numbers)
        {
            _calculateService.SetData(numbers);
            _viewReport.Show();
            _viewReport.UpdateNumbers(numbers);
        }

        private void ShowInfo()
        {
            _view.ShowInfo(_calculateService.GetResultNow());
        }

        private void ClickZero()
        {
            string zero = _view.Zero;
            _calculateService.CurrentNumber(zero);
            ShowInfo();
        }

        private void ClickNine()
        {
            string nine = _view.Nine;
            _calculateService.CurrentNumber(nine);
            ShowInfo();
        }

        private void ClickEight()
        {
            string eight = _view.Eight;
            _calculateService.CurrentNumber(eight);
            ShowInfo();
        }

        private void ClickSeven()
        {
            string seven = _view.Seven;
            _calculateService.CurrentNumber(seven);
            ShowInfo();
        }

        private void ClickSix()
        {
            string six = _view.Six;
            _calculateService.CurrentNumber(six);
            ShowInfo();
        }

        private void ClickFive()
        {
            string five = _view.Five;
            _calculateService.CurrentNumber(five);
            ShowInfo();
        }

        private void ClickFour()
        {
            string four = _view.Four;
            _calculateService.CurrentNumber(four);
            ShowInfo();
        }

        private void ClickThree()
        {
            string three = _view.Three;
            _calculateService.CurrentNumber(three);
            ShowInfo();
        }

        private void ClickTwo()
        {
            string two = _view.Two;
            _calculateService.CurrentNumber(two);
            ShowInfo();
        }

        private void ClickOne()
        {
            string one = _view.One;
            _calculateService.CurrentNumber(one);
            ShowInfo();
        }
        private void ExecuteOperationExecute(Operation operation)
        {
            List<Double> numbers = _calculateService.Execute(operation);
            _viewReport.UpdateNumbers(numbers);  
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
