using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APF_Calculadora
{
    public partial class Calculadora : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNumClick(object sender, EventArgs e)
        {
            tbNumbers.Text += ((Button)sender).Text;

        }
        private static int num1 = 0;
        private static int num2 = 0;
        private static string operationType = "";
        protected void btnOperation(object sender, EventArgs e)
        {
            if(tbOperation.Text == "")
            {
                num1 = Convert.ToInt32(tbNumbers.Text);
                operationType = ((Button)sender).Text;

                tbOperation.Text = $"{num1} {operationType}";

                tbNumbers.Text = "";
            }
            else
            {
                num2 = Convert.ToInt32(tbNumbers.Text);
                operation();
            }
        }
        protected void btnResultOperation(object sender, EventArgs e)
        {
            if(tbOperation.Text != "")
            {
                num2 = Convert.ToInt32(tbNumbers.Text);
                operation();
            }
        }

        private void operation()
        {
            if (operationType == "+")
            {
                tbOperation.Text = Convert.ToString(num1 + num2);

                num1 = 0; num2 = 0; operationType = "";
                tbNumbers.Text = "";
            }
            else if (operationType == "-")
            {
                tbOperation.Text = Convert.ToString(num1 * num2);

                num1 = 0; num2 = 0; operationType = "";
                tbNumbers.Text = "";
            }
            else if (operationType == "X")
            {
                tbOperation.Text = Convert.ToString(num1 * num2);

                num1 = 0; num2 = 0; operationType = "";
                tbNumbers.Text = "";
            }
            else if (operationType == "/")
            {
                tbOperation.Text = Convert.ToString(num1 / num2);

                num1 = 0; num2 = 0; operationType = "";
                tbNumbers.Text = "";
            }
        }
    }
}