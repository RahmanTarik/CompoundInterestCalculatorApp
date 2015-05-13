using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundInterestCalculatorApp
{
    public partial class CompoundInterestCalculatorUi : Form
    {
        public CompoundInterestCalculatorUi()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
                double principalAmount = Convert.ToDouble(principalAmountTextBox.Text);
                double interestRate = Convert.ToDouble(interestRateTextBox.Text) / 100;
                int compoundInterest = Convert.ToInt32(compoundInterestTextBox.Text);
                int yearsToGrow = Convert.ToInt32(yearsToGrowTextBox.Text);
                double total = principalAmount * Math.Pow((1 + interestRate / compoundInterest), compoundInterest * yearsToGrow);
                totalAmountTextBox.Text = Math.Round(total, 2).ToString();
                ClearField();
            
        }

        private void ClearField()
        {
            principalAmountTextBox.Text = String.Empty;
            interestRateTextBox.Text = String.Empty;
            compoundInterestTextBox.Text = String.Empty;
            yearsToGrowTextBox.Text = String.Empty;
        }

       
    }
}
