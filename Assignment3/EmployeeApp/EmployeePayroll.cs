/*
 * Program : Employee Payroll App
 * Made by Subi
 * Dtae : 11/10/2025
 * 
 * EmployeePayRoll.cs
 * This program calculates employee pay (including overtime) and also saves and loads data from a file.
 */

using System.Windows.Forms;
using System.IO;

namespace EmployeeApp
{
    public partial class EmployeePayroll : Form
    {
        public EmployeePayroll()
        {
            InitializeComponent();
        }

        // Calculates total pay
        private double CalculatePay(double rate, double hours)
        {
            if (hours <= 40)
                return rate * hours;
            else
                return (40 * rate) + ((hours - 40) * rate * 1.5);
        }

        // Saves employee data to text file if button is clicked
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Reads and validate input from text boxes
                string name = textBoxName.Text.Trim();
                string number = textBoxNumber.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(number))
                {
                    MessageBox.Show("Please enter both employee name and number.",
                                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parses numeric values
                double rate = double.Parse(textBoxRate.Text);
                double hours = double.Parse(textBoxHour.Text);

                // Computes total pay
                double totalPay = CalculatePay(rate, hours);

                // Opens Save File Dialog
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text Files (*.txt)|*.txt";
                saveDialog.Title = "Save Employee Data";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Writes data to file
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine(name);
                        writer.WriteLine(number);
                        writer.WriteLine(totalPay.ToString("F2"));
                    }

                    MessageBox.Show("Employee data saved successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Pay Rate and Hours.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Loads employee data from a text file
        private void buttonLoad_Click(object sender, EventArgs e)
        {

            try
            {
                // Opens Save File Dialog
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Text Files (*.txt)|*.txt";
                openDialog.Title = "Open Employee Data";

                // Reads employee data from file
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openDialog.FileName))
                    {
                        string name = reader.ReadLine();
                        string number = reader.ReadLine();
                        string pay = reader.ReadLine();
                        // Displays employee info in the text box
                        textBoxDisplay.Text = $"Employee: {name}\r\n" +
                                              $"Number: {number}\r\n" +
                                              $"Total Pay: ${pay}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
