using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEx1
{
    public partial class Currency_Converter : Form
    {
        private double ratio = 0;

        public Currency_Converter()
        {
            InitializeComponent();
        }

        private void Currency_Converter_Load(object sender, EventArgs e)
        {
            this.Text = "CurrencyConverterApp";
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == 0)
            {
                this.ratio = 0.75;
            }
            else if (cmbCurrency.SelectedIndex == 1)
            {
                this.ratio = 0.77;
            }
            else if (cmbCurrency.SelectedIndex == 2)
            {
                this.ratio = 1.16;
            }
            else if (cmbCurrency.SelectedIndex == 3)
            {
                this.ratio = 1.33;
            }
            else if (cmbCurrency.SelectedIndex == 4)
            {
                this.ratio = 1;
            }
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            string output;
            output = this.textBox1.Text;
            double outputNum;
            outputNum = double.Parse(output);
            outputNum = outputNum * this.ratio;


            this.lbl3.Text = String.Format("{0}", outputNum);
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}

