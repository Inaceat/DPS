using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private delegate double FooXY(double x, double y);

        private FooXY[] _functions =
        {
            (x, y) => Math.Exp(x)*Math.Sin(y),
            (x, y) => Math.Sin(x + 2*y),
            (x, y) => Math.Cos(x * Math.Exp(y)),
            (x, y) => Math.Exp(Math.Cos(x*x+y))
        };

        private class IntegralTask
        {
            FooXY Foo;
            double X0;
            double X1;
            double Y0;
            double Y1;

            public IntegralTask(FooXY foo, double x0, double x1, double y0, double y1)
            {
                Foo = foo;
                X0 = x0;
                X1 = x1;
                Y0 = y0;
                Y1 = y1;
            }

            double Calculate()
            {
                return Foo((X1 + X0) / 2, (Y1 + Y0) / 2) * (X1 - X0) * (Y1 - Y0);
            }
        }


        public Form1()
        {
            InitializeComponent();

            fooInput.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            double d;
            
            try
            {
                a = double.Parse(aInput.Text);
                b = double.Parse(aInput.Text);
                c = double.Parse(aInput.Text);
                d = double.Parse(aInput.Text);
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong input. Try ',' as decimal point.");
                return;
            }

            int n;
            int m;
            try
            {
                n = int.Parse(aInput.Text);
                m = int.Parse(aInput.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input. M and N should be integer.");
                return;
            }
            if(m < 1 || n < 1)
            {
                MessageBox.Show("Wrong input. M and N should be natural.");
                return;
            }



            int threadsToUse;

            try
            {
                threadsToUse = int.Parse(threadsInput.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input. Threads number incorrect.");
                return;
            }


            int totalElements = m * n;
            int threadDataSize, lastThreadDataSize;

            if (0 == totalElements % threadsToUse)
            {
                threadDataSize = totalElements / threadsToUse;
                lastThreadDataSize = 0;
            }
            else
            {
                threadDataSize = totalElements / threadsToUse + 1;
                --threadsToUse;
                lastThreadDataSize = totalElements - threadDataSize * threadsToUse;

            }



            resultOutput.Text = "Yup!";
        }
    }
}
