using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninject;
using System.Windows.Forms;
using Presentation.View;
using Model.Service;
using Model.Repository;
using Presentation.Presenters;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<ICalculatorView>().To<Form1>();
            kernel.Bind<IReportView>().To<ReportForm>();

            kernel.Bind<ICalculateService>().To<CalculateService>().InSingletonScope();

            kernel.Bind<IRepository>().To<Repository>().InSingletonScope();

            kernel.Bind<CalculatorPresenter>().ToSelf();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<CalculatorPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
