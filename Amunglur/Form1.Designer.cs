namespace Amunglur
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
            this.breadInput = new System.Windows.Forms.TextBox();
            this.antiradInput = new System.Windows.Forms.TextBox();
            this.delightInput = new System.Windows.Forms.TextBox();
            this.tradeButton = new System.Windows.Forms.Button();
            this.cashBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.amount1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shopkeepText = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.traderRant1 = new System.Windows.Forms.Label();
            this.priceBeforeTaxOutput = new System.Windows.Forms.Label();
            this.taxAmountOutput = new System.Windows.Forms.Label();
            this.finalPriceOutput = new System.Windows.Forms.Label();
            this.moneyGiven = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.overallReciept = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // breadInput
            // 
            this.breadInput.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.breadInput.Location = new System.Drawing.Point(89, 12);
            this.breadInput.Name = "breadInput";
            this.breadInput.Size = new System.Drawing.Size(100, 23);
            this.breadInput.TabIndex = 0;
            this.breadInput.Text = "0";
            this.breadInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // antiradInput
            // 
            this.antiradInput.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.antiradInput.Location = new System.Drawing.Point(89, 95);
            this.antiradInput.Name = "antiradInput";
            this.antiradInput.Size = new System.Drawing.Size(100, 23);
            this.antiradInput.TabIndex = 1;
            this.antiradInput.Text = "0";
            this.antiradInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // delightInput
            // 
            this.delightInput.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.delightInput.Location = new System.Drawing.Point(89, 54);
            this.delightInput.Name = "delightInput";
            this.delightInput.Size = new System.Drawing.Size(100, 23);
            this.delightInput.TabIndex = 2;
            this.delightInput.Text = "0";
            this.delightInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tradeButton
            // 
            this.tradeButton.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.tradeButton.Location = new System.Drawing.Point(89, 124);
            this.tradeButton.Name = "tradeButton";
            this.tradeButton.Size = new System.Drawing.Size(75, 23);
            this.tradeButton.TabIndex = 3;
            this.tradeButton.Text = "Trade";
            this.tradeButton.UseVisualStyleBackColor = true;
            this.tradeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashBox
            // 
            this.cashBox.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.cashBox.Location = new System.Drawing.Point(63, 241);
            this.cashBox.Name = "cashBox";
            this.cashBox.Size = new System.Drawing.Size(36, 23);
            this.cashBox.TabIndex = 4;
            this.cashBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Transparent;
            this.calculate.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.calculate.Location = new System.Drawing.Point(24, 276);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Provide";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // amount1
            // 
            this.amount1.AutoSize = true;
            this.amount1.BackColor = System.Drawing.Color.Transparent;
            this.amount1.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount1.Location = new System.Drawing.Point(4, 56);
            this.amount1.Name = "amount1";
            this.amount1.Size = new System.Drawing.Size(82, 16);
            this.amount1.TabIndex = 6;
            this.amount1.Text = "Tourist\'s Delight";
            this.amount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amount1.Click += new System.EventHandler(this.amount1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "AntiRad Drugs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bread... Maybe?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.button3.Location = new System.Drawing.Point(25, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Print Receipt?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Owed Amount:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hazard Pay:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Final Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(22, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount owed:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // shopkeepText
            // 
            this.shopkeepText.AutoSize = true;
            this.shopkeepText.BackColor = System.Drawing.Color.Transparent;
            this.shopkeepText.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.shopkeepText.Location = new System.Drawing.Point(443, 98);
            this.shopkeepText.Name = "shopkeepText";
            this.shopkeepText.Size = new System.Drawing.Size(27, 16);
            this.shopkeepText.TabIndex = 18;
            this.shopkeepText.Text = "Cold";
            this.shopkeepText.Click += new System.EventHandler(this.shopkeepText_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.label10.Location = new System.Drawing.Point(443, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Faction:     Clear Sky";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // traderRant1
            // 
            this.traderRant1.BackColor = System.Drawing.Color.Transparent;
            this.traderRant1.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.traderRant1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.traderRant1.Location = new System.Drawing.Point(442, 130);
            this.traderRant1.Name = "traderRant1";
            this.traderRant1.Size = new System.Drawing.Size(100, 169);
            this.traderRant1.TabIndex = 22;
            this.traderRant1.Click += new System.EventHandler(this.traderRant1_Click);
            // 
            // priceBeforeTaxOutput
            // 
            this.priceBeforeTaxOutput.AutoSize = true;
            this.priceBeforeTaxOutput.BackColor = System.Drawing.Color.Transparent;
            this.priceBeforeTaxOutput.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.priceBeforeTaxOutput.Location = new System.Drawing.Point(95, 155);
            this.priceBeforeTaxOutput.Name = "priceBeforeTaxOutput";
            this.priceBeforeTaxOutput.Size = new System.Drawing.Size(0, 16);
            this.priceBeforeTaxOutput.TabIndex = 23;
            this.priceBeforeTaxOutput.Click += new System.EventHandler(this.priceBeforeTax_Click);
            // 
            // taxAmountOutput
            // 
            this.taxAmountOutput.AutoSize = true;
            this.taxAmountOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxAmountOutput.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.taxAmountOutput.Location = new System.Drawing.Point(95, 180);
            this.taxAmountOutput.Name = "taxAmountOutput";
            this.taxAmountOutput.Size = new System.Drawing.Size(0, 16);
            this.taxAmountOutput.TabIndex = 24;
            this.taxAmountOutput.Click += new System.EventHandler(this.taxAmount2_Click);
            // 
            // finalPriceOutput
            // 
            this.finalPriceOutput.AutoSize = true;
            this.finalPriceOutput.BackColor = System.Drawing.Color.Transparent;
            this.finalPriceOutput.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.finalPriceOutput.Location = new System.Drawing.Point(95, 204);
            this.finalPriceOutput.Name = "finalPriceOutput";
            this.finalPriceOutput.Size = new System.Drawing.Size(0, 16);
            this.finalPriceOutput.TabIndex = 25;
            this.finalPriceOutput.Click += new System.EventHandler(this.finalPrice1_Click);
            // 
            // moneyGiven
            // 
            this.moneyGiven.AutoSize = true;
            this.moneyGiven.BackColor = System.Drawing.Color.Transparent;
            this.moneyGiven.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.moneyGiven.ForeColor = System.Drawing.SystemColors.Control;
            this.moneyGiven.Location = new System.Drawing.Point(14, 244);
            this.moneyGiven.Name = "moneyGiven";
            this.moneyGiven.Size = new System.Drawing.Size(39, 16);
            this.moneyGiven.TabIndex = 26;
            this.moneyGiven.Text = "Rubles:";
            this.moneyGiven.Click += new System.EventHandler(this.moneyGiven_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Amunglur.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(437, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.button1.Location = new System.Drawing.Point(437, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Print New Reciept?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.button2.Location = new System.Drawing.Point(437, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Start New Order?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // overallReciept
            // 
            this.overallReciept.BackColor = System.Drawing.Color.Transparent;
            this.overallReciept.Location = new System.Drawing.Point(204, 12);
            this.overallReciept.Name = "overallReciept";
            this.overallReciept.Size = new System.Drawing.Size(222, 208);
            this.overallReciept.TabIndex = 30;
            this.overallReciept.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 6.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(102, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 31;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::Amunglur.Properties.Resources.sf09cfce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.overallReciept);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moneyGiven);
            this.Controls.Add(this.finalPriceOutput);
            this.Controls.Add(this.taxAmountOutput);
            this.Controls.Add(this.priceBeforeTaxOutput);
            this.Controls.Add(this.traderRant1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.shopkeepText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.cashBox);
            this.Controls.Add(this.tradeButton);
            this.Controls.Add(this.delightInput);
            this.Controls.Add(this.antiradInput);
            this.Controls.Add(this.breadInput);
            this.Name = "Form1";
            this.Text = "Cold\'s Trade Emporium";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox breadInput;
        private System.Windows.Forms.TextBox antiradInput;
        private System.Windows.Forms.TextBox delightInput;
        private System.Windows.Forms.Button tradeButton;
        private System.Windows.Forms.TextBox cashBox;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label amount1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label shopkeepText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label traderRant1;
        private System.Windows.Forms.Label priceBeforeTaxOutput;
        private System.Windows.Forms.Label taxAmountOutput;
        private System.Windows.Forms.Label finalPriceOutput;
        private System.Windows.Forms.Label moneyGiven;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label overallReciept;
        private System.Windows.Forms.Label label1;
    }
}

