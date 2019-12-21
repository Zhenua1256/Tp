using Model.Entity;
using Presentation.View;
using SuperCalculator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form, ICalculatorView
    {
        private ApplicationContext _applicationContext;

        public event Action ClickOne;
        public event Action ClickTwo;
        public event Action ClickThree;
        public event Action ClickFour;
        public event Action ClickFive;
        public event Action ClickSix;
        public event Action ClickSeven;
        public event Action ClickEight;
        public event Action ClickNine;
        public event Action ClickZero;
        public event Action ClickBlank;

      

        public event Delegates.OperationExecuteDelegate OperationExecuteEvent;
       
        
        public event Delegates.SetData1 SetData;

        public string One => button15.Text;
        public string Two => button16.Text;
        public string Three => button17.Text;
        public string Four => button13.Text;
        public string Five => button12.Text;
        public string Six => button14.Text;
        public string Seven => button9.Text;
        public string Eight => button10.Text;
        public string Nine => button11.Text;
        public string Zero => button19.Text;
        public string Blank => button28.Text;

        public Form1(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            InitializeComponent();
        }

        //event Presentation.View.SetData1 ICalculatorView.SetData
        //{
        //    add
        //    {
                
        //    }

        //    remove
        //    {
              
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new DivisionOperation(Double.Parse(input.Text)));
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new KvadratOperation());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new RootOperation());
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new MultiplicationOperation(Double.Parse(input.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClickSeven?.Invoke();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            ClickZero?.Invoke();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ClickOne?.Invoke();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClickEight?.Invoke();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClickSix?.Invoke();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClickTwo?.Invoke();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ClickThree?.Invoke();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ClickFour?.Invoke();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClickFive?.Invoke();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClickNine?.Invoke();
        }

        public void ShowInfo(string resultNow)
        {
            textBox1.Text = resultNow;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] strings = textBox1.Text.Split(' ');
            List<Double> bigIntegers = strings.Select(numberString => Double.Parse(numberString)).ToList();
            SetData?.Invoke(bigIntegers);
           
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ClickBlank?.Invoke();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\input.txt");
            List<Double> bigIntegers = new List<Double>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                bigIntegers.Add(Double.Parse(line));
            }
            SetData?.Invoke(bigIntegers);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\output.txt");
            string[] strings = textBox1.Text.Split(' ');
            List<Double> bigIntegers = strings.Select(numberString => Double.Parse(numberString)).ToList();
            bigIntegers.ForEach(number => sw.WriteLine(number));
            sw.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new SumOperation(Double.Parse(input.Text)));
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new MinusOperation(Double.Parse(input.Text)));
        }
    }
}
