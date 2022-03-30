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
        //OLD CODE
        /*
        public void fnCalc(float fAge, float fPrice)
        {
            float fWorth = fPrice * .2f * fage;
            if (fWorth >= fPrice)
            {
                //old code
                //lblWorth.Text = "This textboox is worthless";
                return;
            }
            //age is no greater than or = to 5
            else
            { 
                //old code
                //fPrice = fPrice - fWorth;
                //lblWorth.Text = $"The textbook is worth ${fPrice.ToString()}";
                //update the total worth
                //fTotal += fPrice;
                //lblTotal.Text = $"The collection is worth ${fTotal.ToString()}";

            }
        }
        */

        //Function: Calculate the worth of the textbook
        //Input: float Purchedval, float Age, The purchased value and age
        //OutPut: the value of the textbook
        private float Calc(float purchedVal, float Age)
        {
            float depreciation = purchedVal * .2f * Age;
            if(depreciation > purchedVal)
            {
                return 0f;
            }
            return purchedVal - depreciation;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //make sure that the value is not negative
            if (numAge.Value > 0 & numPrice.Value > 0)
            {
                //set the values to be floats
                //call the function to a var
                float Val = Calc((float)numPrice.Value, (float)numAge.Value);
                if (Val == 0)
                {
                    lblWorth.Text = "This textbook is worthless";
                }
                else
                {
                    lblWorth.Text = $"This textbook is worth ${Val}";
                    fTotal += Val;
                    lblTotal.Text = $"The Collection is worth ${fTotal}";
                }
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
            fTotal = 0;
        }
    }
}
