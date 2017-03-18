using ConsumeWcf.ProxyWcfCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeWcf
{
    public partial class WcfCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CalculatorClient webcalculator = new CalculatorClient("BasicHttpBinding_ICalculator");
            int addition = webcalculator.add(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text));
            int subtraction = webcalculator.sub(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text));
            int division = webcalculator.div(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text));
            int multiplication = webcalculator.mul(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text));

            TextBox3.Text = addition.ToString();
            TextBox4.Text = subtraction.ToString();
            TextBox5.Text = multiplication.ToString();
            TextBox6.Text = multiplication.ToString();
        }
    }
}