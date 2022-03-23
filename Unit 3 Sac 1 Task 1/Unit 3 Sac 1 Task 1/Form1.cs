using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Unit 3 Sac 1 Task 1, Leonardo Bini, 23/03/2022

namespace Unit_3_Sac_1_Task_1
{
    public partial class Form1 : Form
    {
        float fTotal = 0f;

        public Form1()
        {
            InitializeComponent();
        }


        //Function: Reads how old the book and what the price was
        //Input: float, Age
        //Output: float, fTotal, fWorth

        public void fnCalc(float fage, float fPrice)
        {
            float fWorth = fPrice * .2f * fage;
            if (fWorth >= fPrice)
            {
                lblWorth.Text = "This textboox is worthless";
                return;
            }
            //age is no greater than or = to 5
            else
            {
                fPrice = fPrice - fWorth;
                lblWorth.Text = $"The textbook is worth ${fPrice.ToString()}";
                //update the total worth
                fTotal += fPrice;
                lblTotal.Text = $"The collection is worth ${fTotal.ToString()}";

            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //make sure that the value is not negative
            if (numAge.Value > 0 & numPrice.Value > 0)
            {
                //number updown box value converted to flaot
                //call function
                fnCalc((float)numAge.Value, (float)numPrice.Value);
            }

            else
            {
                //present user with error
                MessageBox.Show("0 is not valid");
            }

        }
        
        //reset all fields
        private void btnEndQuote_Click(object sender, EventArgs e)
        {
            numPrice.Value = 0;
            numAge.Value = 0;
            lblWorth.Text = "Quote Ended";
            lblTotal.Text = "Quote Ended";
        }
    }
}
