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

        private static double num1 = 0;
        private static double num2 = 0;
        private static string operationType = "";

        // funcion btn numeros
        protected void btnNumClick(object sender, EventArgs e)
        {
            tbNumbers.Text += ((Button)sender).Text;

        }

        protected void btnOperation(object sender, EventArgs e)
        {
            if(tbNumbers.Text.Length > 0 && tbOperation.Text.Length == 0 && operationType == "")
            {
                num1 = Convert.ToDouble(tbNumbers.Text);
                operationType = ((Button)sender).Text;

                tbOperation.Text = $"{num1} {operationType}";

                tbNumbers.Text = "";
            }
            else if(tbOperation.Text.Length > 0 && operationType == "")
            {
                operationType = ((Button)sender).Text;
                if (tbNumbers.Text.Length > 0)
                {
                    num2 = Convert.ToDouble(tbNumbers.Text);
                    operation();
                }
                else
                {
                    tbOperation.Text += $" {operationType}";
                }
            }
            else if(tbOperation.Text.Length>0 && operationType != "" && tbNumbers.Text.Length > 0)
            {
                num2 = Convert.ToDouble(tbNumbers.Text);
                operation();
                operationType = ((Button)sender).Text;
                tbOperation.Text += $" {operationType}";
            }
        }
        protected void btnResultOperation(object sender, EventArgs e)
        {
            if(tbOperation.Text.Length > 0 && operationType != "")
            {
                num2 = Convert.ToDouble(tbNumbers.Text);
                operation();
            }
        }

        private void operation()
        {
            switch (operationType)
            {
                case "+":
                    tbOperation.Text = Convert.ToString(num1 + num2);
                    break;

                case "-":
                    tbOperation.Text = Convert.ToString(num1 - num2);
                    break;

                case "*":
                    tbOperation.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    tbOperation.Text = Convert.ToString(num1 / num2);
                    break;
            }
            num1 = Convert.ToInt32(tbOperation.Text);
            num2 = 0; operationType = "";
            tbNumbers.Text = "";
        }
    }
}