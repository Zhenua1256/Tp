using Presentation.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ReportForm : Form, IReportView
    {
        private ApplicationContext _applicationContext;
        public ReportForm(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            InitializeComponent();
        }
        

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateNumbers(List<Double> numbers)
        {
            string result = "";
            result += string.Join(" ", numbers);

            string tempStr = data.Text;
            tempStr += "\n" + result;
            data.Text = tempStr;
        }

        private void data_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
