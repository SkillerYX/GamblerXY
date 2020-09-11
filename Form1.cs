using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gambler
{
    public partial class Form1 : Form
    {
        public double money=50;
        public double moneywon=0;
        public string results;

        Random RNG = new Random(); //método da classe random.
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = RNG.Next(0, 100); //te dá um número aleatório entre 0 e 100 (foram os escolhidos).

            if (result > 40)
            {
                lb_result.ForeColor = Color.Green;
                lb_result.Text = "You Win";
                moneywon = (100 + result * 1.32)/100;
                lb_rm.Text = string.Format("You've Won: ${0}", moneywon.ToString());
                money += moneywon;
                lb_money.Text = string.Format("Total: ${0}", money.ToString());
            }
            else {
                lb_result.ForeColor = Color.Red;
                lb_result.Text = "You Lose";
                moneywon = 0;
                lb_rm.Text = string.Format("You've Won: ${0}", moneywon.ToString());
                money = 0;
                lb_money.Text = string.Format("Total: ${0}", money.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_money.Text = string.Format("Total: ${0}", money.ToString());
            lb_rm.Text = string.Format("You've Won: ${0}", moneywon.ToString());
            lb_result.Text = "";
        }
    }
}
