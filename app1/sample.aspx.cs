using System;

namespace app1
{
    public partial class sample : System.Web.UI.Page
    {
        // This method is triggered when the page is loaded
        protected void Page_Load(object sender, EventArgs e)
        {
            // You can add any logic that needs to run when the page loads, but we don't need to do anything here for now.
        }

        // Event handler for the btnCalculate button click
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the values from the textboxes
                double number1 = double.Parse(TextBox1.Text); // First number
                double number2 = double.Parse(TextBox2.Text); // Second number

                // Retrieve the selected operation from the dropdown list
                string operation = ddlOperation.SelectedValue;

                double result = 0; // This will store the result of the calculation

                // Perform the selected operation
                switch (operation)
                {
                    case "Add":
                        result = number1 + number2;
                        break;
                    case "Subtract":
                        result = number1 - number2;
                        break;
                    case "Multiply":
                        result = number1 * number2;
                        break;
                    case "Divide":
                        if (number2 != 0) // Check for division by zero
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            lblResult.Text = "Error: Division by zero is not allowed.";
                            return;
                        }
                        break;
                    default:
                        lblResult.Text = "Error: Invalid operation.";
                        return;
                }

                // Display the result in the label
                lblResult.Text = $"Result: {result}";
            }
            catch (FormatException)
            {
                // If the user input is not a valid number, show an error message
                lblResult.Text = "Error: Please enter valid numbers.";
            }
            catch (Exception ex)
            {
                // Catch any other errors and display the error message
                lblResult.Text = $"Error: {ex.Message}";
            }
        }
    }
}
