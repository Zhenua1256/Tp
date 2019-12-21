using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{

    public interface ICalculatorView: IView
    {
        event Action ClickOne;
        event Action ClickTwo;
        event Action ClickThree;
        event Action ClickFour;
        event Action ClickFive;
        event Action ClickSix;
        event Action ClickSeven;
        event Action ClickEight;
        event Action ClickNine;
        event Action ClickZero;
        event Action ClickBlank;

        event Delegates.OperationExecuteDelegate OperationExecuteEvent;

        event Delegates.SetData1 SetData;

        string One { get; }
        string Two { get; }
        string Three { get; }
        string Four { get; }
        string Five { get; }
        string Six { get; }
        string Seven { get; }
        string Eight { get; }
        string Nine { get; }
        string Zero { get; }
        string Blank { get; }



        void ShowInfo(string resultNow);
    }
}
