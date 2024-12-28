using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assigments
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnWelcome_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            lblWelcomeMessage.Text = !string.IsNullOrEmpty(name) ? $"Welcome, {name}!" : "Please enter your name.";
        }

        protected void BtnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtTemperature.Text.Trim(), out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblTemperatureResult.Text = $"Temperature in Fahrenheit: {fahrenheit:F2}°F";
            }
            else
            {
                lblTemperatureResult.Text = "Please enter a valid temperature in Celsius.";
            }
        }

        protected void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text.Trim(), out double num1) && double.TryParse(txtNumber2.Text.Trim(), out double num2))
            {
                string operation = ddlOperation.SelectedValue;
                double result = 0;

                if (operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else if (operation == "*")
                {
                    result = num1 * num2;
                }
                else if (operation == "/")
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        lblCalculationResult.Text = "Division by zero is not allowed.";
                        return;
                    }
                }
                else
                {
                    lblCalculationResult.Text = "Invalid operation selected.";
                    return;
                }

                lblCalculationResult.Text = $"Result: {result:F2}";
            }
            else
            {
                lblCalculationResult.Text = "Please enter valid numbers.";
            }
        }

        protected void DdlColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = ddlColors.SelectedValue;
            lblColorMessage.Text = !string.IsNullOrEmpty(selectedColor)
                ? $"You selected: {selectedColor}"
                : "Please select a color.";
            lblColorMessage.Style["color"] = selectedColor.ToLower();
        }
    }
}