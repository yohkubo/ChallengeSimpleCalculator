using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            string i = firstValueTextBox.Text;
            string j = secondValueTextBox.Text;
            double k = double.Parse(i);  // integer firstValue
            double l = double.Parse(j);  // integer secondValue

            double result = (double)k + (double)l;

            resultLabel.Text = result.ToString();

        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            string i = firstValueTextBox.Text;
            string j = secondValueTextBox.Text;
            double k = double.Parse(i);  // integer firstValue
            double l = double.Parse(j);  // integer secondValue

            double result = (double)k - (double)l;

            resultLabel.Text = result.ToString();

        }

        protected void timesButton_Click(object sender, EventArgs e)
        {
            string i = firstValueTextBox.Text;
            string j = secondValueTextBox.Text;
            double k = double.Parse(i);  // integer firstValue
            double l = double.Parse(j);  // integer secondValue

            double result = (double)k * (double)l;

            resultLabel.Text = result.ToString();

        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            string i = firstValueTextBox.Text;
            string j = secondValueTextBox.Text;
            double k = double.Parse(i);  // integer firstValue
            double l = double.Parse(j);  // integer secondValue

            double result = (double)k / (double)l;

            resultLabel.Text = result.ToString();

        }
    }
}