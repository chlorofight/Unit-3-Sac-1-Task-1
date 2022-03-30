namespace Unit_3_Sac_1_Task_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnEndQuote = new System.Windows.Forms.Button();
            this.lblWorth = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(29, 13);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(201, 22);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "How old Is the text book";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(29, 112);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(191, 22);
            this.lblPaid.TabIndex = 3;
            this.lblPaid.Text = "How much did you pay";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(33, 199);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(95, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnEndQuote
            // 
            this.btnEndQuote.Location = new System.Drawing.Point(276, 199);
            this.btnEndQuote.Name = "btnEndQuote";
            this.btnEndQuote.Size = new System.Drawing.Size(135, 23);
            this.btnEndQuote.TabIndex = 5;
            this.btnEndQuote.Text = "End the quote";
            this.btnEndQuote.UseVisualStyleBackColor = true;
            this.btnEndQuote.Click += new System.EventHandler(this.btnEndQuote_Click);
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorth.Location = new System.Drawing.Point(500, 30);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(145, 22);
            this.lblWorth.TabIndex = 6;
            this.lblWorth.Text = "Please Calculate";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(500, 112);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 22);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Please Calculate";
            // 
            // numPrice
            // 
            this.numPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(33, 147);
            this.numPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(158, 22);
            this.numPrice.TabIndex = 2;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(33, 54);
            this.numAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(158, 22);
            this.numAge.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblWorth);
            this.Controls.Add(this.btnEndQuote);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnEndQuote;
        private System.Windows.Forms.Label lblWorth;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numAge;
    }
}

