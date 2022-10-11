using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; // add this to your using statements to play .wav sounds 

namespace Amunglur
{

    public partial class Form1 : Form
    {
        double breadPrice = 2.00;
        double delightPrice = 5.50;
        double antiradPrice = 12.50;

        double breadAmount = 0;
        double delightAmount = 0;
        double antiradAmount = 0;

        double taxAmount = 0.165;
        double subTotal = 0;
        double done = 0;

        double cashBoxamount = 0;
        double taxamount1 = 0;
        double label111 =0; 
        public Form1()
        {
            InitializeComponent();
            traderRant1.BackColor = Color.FromArgb(125, 255,255,255);
            label3.BackColor = Color.FromArgb(125, 255, 255, 255);
            amount1.BackColor = Color.FromArgb(125, 255, 255, 255);
            label2.BackColor = Color.FromArgb(125, 255, 255, 255);
            label4.BackColor = Color.FromArgb(125, 255, 255, 255);
            label5.BackColor = Color.FromArgb(125, 255, 255, 255);
            label6.BackColor = Color.FromArgb(125, 255, 255, 255);
            moneyGiven.BackColor = Color.FromArgb(125, 255, 255, 255);
            label1.BackColor = Color.FromArgb(125, 255, 255, 255);
            label8.BackColor = Color.FromArgb(125, 255, 255, 255);
            label10.BackColor = Color.FromArgb(125, 255, 255, 255);
            shopkeepText.BackColor = Color.FromArgb(125, 255, 255, 255);
            finalPriceOutput.BackColor = Color.FromArgb(125, 255, 255, 255);
            taxAmountOutput.BackColor = Color.FromArgb(125, 255, 255, 255);
            priceBeforeTaxOutput.BackColor = Color.FromArgb(125, 255, 255, 255);
        }




        private void label4_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "It's the money you owe me before I calculate the tax.";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "It takes both time and money to collect these objects, friend. This just makes sure something makes it into my pocket at the end of the day.";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "A more accurate reflection of what you owe following my calculations of the hazard pay. Don't worry, shouldn't be too high.";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "This is just here if you pay me more than you need to. Basically however much I have to pay you back.";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                //get inputs
                breadAmount = Convert.ToDouble(breadInput.Text);
                delightAmount = Convert.ToDouble(delightInput.Text);
                antiradAmount = Convert.ToDouble(antiradInput.Text);

                //do calculations
                subTotal = breadAmount * breadPrice + delightAmount * delightPrice + antiradAmount * antiradPrice;
                taxAmount = subTotal * 0.13;
                done = taxAmount + subTotal;


                //show outputs
                priceBeforeTaxOutput.Text = subTotal.ToString("C");
                taxAmountOutput.Text = taxAmount.ToString("C");
                finalPriceOutput.Text = done.ToString("C");
                 

                //taxAmountOutput.Text = $"{taxAmount * subTotal}";
                //finalPriceOutput.Text = $"{taxAmountOutput + subTotal}";


                //priceBeforeTax = Bread + Tdel + Antir * Amount;
                //taxAmount2Output = priceBeforeTax * taxAmount3




                // priceBeforeTaxOutput.Text = $"{priceBeforeTax.ToString("C")}";
                // taxAmount2Output.Text = $"{taxAmount2.ToString("C")}";
                // finalPriceOutput.Text = $"{finalPrice.ToString("C")}";
            }
            catch
            {
                traderRant1.Refresh();
                traderRant1.Text = "Have you been hit with an emission? Please use numbers next time you ask for items.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashBoxamount = Convert.ToDouble(cashBox.Text);
            label1.Text = label111.ToString("C");
            label1.Text = $"{cashBoxamount - done}";
            traderRant1.Refresh();
            traderRant1.Text = "спасибо, friend! If I owe you anything, I'll give it forward. Try not to die, alright? I need repeat customers here, after all!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  outputLabel.Text += "\n  Hi again"; is an example of the line to utilize. 
            
            taxamount1 = taxAmount + 0;
            cashBoxamount = Convert.ToDouble(cashBox.Text);
            label111 = cashBoxamount - done;

            traderRant1.Refresh();
            traderRant1.Text = "Just wait for it to print... It's an old machine. I'd probably be better off selling it for parts.";

            overallReciept.Text = "                   Cold's Trade Emporium";
            overallReciept.BackColor = Color.White;
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n   'Bread' Purchased:...................{breadAmount}";
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n    Tourist's Delight Purchased:......{delightAmount}";
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n    AntiRad Drugs Purchased:..........{antiradAmount}";
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n     Inital Price:.........................{subTotal}";
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n     Hazard Pay:.........................{taxamount1}";
            overallReciept.Refresh();
            Thread.Sleep(700);
            
            overallReciept.Text += $"\n     Final Price:..............................{done}";
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n     Rubles Provided:.................{cashBoxamount}";
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n     Amount Owed:..........................{label111}";
            overallReciept.Refresh();
            Thread.Sleep(700);

            overallReciept.Text += $"\n\n  Thank you for stopping by! Stay away from The Garbage!                              ";
            overallReciept.Refresh();
            Thread.Sleep(700);
        }

        private void shopkeepText_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "That's me.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            traderRant1.Text = "Yep. That's my face. At least, I hope so.";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "This is the group I'm affiliated with. You'd better pair up with a group if you want to survive out here, and I humbly suggest Clear Sky.";
        }

        private void priceBeforeTax_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "What? dissatisfied with the price? Just wait 'til you see it after taxes.";
        }

        private void taxAmount2_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "My sympathies, comrade. I'm not a fan of taxes, either. That's why I live out here.";
        }

        private void finalPrice1_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "Sorry, friend, but a man's gotta make money somehow.";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "You want something else? my pleasure! So long as you're buying something. Who knows what'll happen to you out there if you don't. I'm kidding, of course - you're gonna die.";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            traderRant1.Text = "We're fairly sure it's bread, at least. No bakers have been reported in The Zone, but we haven't had any complaints thus far, and it doesn't seem to mold.";
        }

        private void amount1_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "A standard tin can full of non-perishable meat, canned vegetables, and a small water ration. Most people coming here for the first time bring some variation of this.";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "A small injector containing a liquid that removes radiation over time. Not particulairly useful as a proactive device. I'm not sure what's in the injector per se, but nobody's died from it yet.";
        }

        private void moneyGiven_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "What are you, a foreigner? It's Russian currency, imported from outside of The Zone. Basically, it's money. Your equivalent of a Dollar, Euro - whatever you've got back home.";
        }

        private void traderRant1_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "That's my mouth. Please don't touch that, it's not for sale.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "Hello, Stalker! I've got everything someone like you could ever need to survive out there in The Zone... except for the things we don't have.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            traderRant1.Refresh();
            traderRant1.Text = "The amount owed. What, is there a problem?";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            traderRant1.Text = "Was there an error or something?";
        }
    }
}
