using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operation;     


namespace Calculater
{
    public partial class Form1 : Form
    {
            bool bOperate = false;
            Operation.Operation oper;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (bOperate)
            {
                txtShow.Text = "";
                bOperate = false;
            }

            string number = ((Button)sender).Text;

            txtShow.Text =Operation. Operation.checkNumberInput(txtShow.Text, number);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                oper = OperationFactory.createOperate(((Button)sender).Text);

                oper.NumberA = Convert.ToDouble(txtShow.Text);

                bOperate = true;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                if (((Button)sender).Text != "=")
                {
                    oper = OperationFactory.createOperate(((Button)sender).Text);
                }

                oper.NumberB = Convert.ToDouble(txtShow.Text);


                txtShow.Text = oper.GetResult().ToString();
                bOperate = true;
            }
        }
    }
}
