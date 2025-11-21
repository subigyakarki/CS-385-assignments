/*
 * Program : Number Sets Binary App
 * Made by Subi
 * Date : 11/10/2025
 * 
 * Form1.cs
 * This Windows Forms application allows the user to enter multiple sets of five 
 * numbers. For each set, the program calculates the average and stores both the 
 * numbers and the average in a binary file. The user can save and close the file, 
 * then reopen it to display all sets with averages in a ListBox.
 *    
 */
using System.IO;
namespace BinaryApp
{
    public partial class Form1 : Form
    {
        // BinaryWriter to write data to the binary file
        private BinaryWriter writer;

        // File path selected by the user
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for "Add Set" button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Reads the numbers entered in the TextBox and trim whitespace
                string input = textBoxNumbers.Text.Trim();

                // Splits input by spaces into an array of strings
                string[] parts = input.Split(' ');

                // Ensures the user entered exactly 5 numbers
                if (parts.Length != 5)
                {
                    MessageBox.Show("Please enter exactly 5 numbers.", "Input Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exits the method if input is invalid
                }

                double[] numbers = new double[5]; // Array to store parsed numbers
                double sum = 0;                    // Variable to store sum for average calculation

                // Parsse each number and calculate the sum
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = double.Parse(parts[i]); // Converts string to double
                    sum += numbers[i];                   // Adds to sum
                }

                // Calculates average
                double average = sum / 5.0;

                // If the writer is not open yet, open the file using SaveFileDialog
                if (writer == null)
                {
                    SaveFileDialog saveDlg = new SaveFileDialog();
                    saveDlg.Filter = "Binary Files (*.bin)|*.bin"; // Only allows .bin files
                    saveDlg.Title = "Save Number Sets";

                    // Shows dialog to user
                    if (saveDlg.ShowDialog() == DialogResult.OK)
                    {
                        filePath = saveDlg.FileName; // Stores selected file path
                        writer = new BinaryWriter(File.Open(filePath, FileMode.Create)); // Open file
                    }
                    else
                    {
                        return; // User cancelled file selection
                    }
                }

                // Writes each number to the binary file
                foreach (double num in numbers)
                    writer.Write(num);

                // Writes the average to the binary file
                writer.Write(average);

                // Informs the user that the set was added successfully
                MessageBox.Show($"Set added successfully! Average = {average:F2}", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clears the TextBox for next input and set focus back to it
                textBoxNumbers.Clear();
                textBoxNumbers.Focus();
            }
            catch (FormatException)
            {
                // Handlse non-numeric input
                MessageBox.Show("Please enter valid numbers separated by spaces.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handlse any other unexpected errors
                MessageBox.Show("Error: " + ex.Message, "Unexpected Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for "Save & Close File" button click
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (writer != null)
            {
                writer.Close(); // Closes the binary writer to save file
                writer = null;  // Resets writer
                MessageBox.Show("File saved successfully!", "Saved",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Informs user if no data was written
                MessageBox.Show("No data to save.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for "Save & Close File" button click
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (writer != null)
            {
                writer.Close(); // Closes the binary writer to save file
                writer = null;  // Resets writer
                MessageBox.Show("File saved successfully!", "Saved",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Informs user if no data was written
                MessageBox.Show("No data to save.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for "Load from File" button click
        private void Load_Click(object sender, EventArgs e)
        {
            try
            {
                // Shows OpenFileDialog to select the binary file
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Filter = "Binary Files (*.bin)|*.bin";
                openDlg.Title = "Open Number Sets";

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    listBoxResults.Items.Clear(); // Clears previous results from ListBox

                    // Opens binary file for reading
                    using (BinaryReader reader = new BinaryReader(File.Open(openDlg.FileName, FileMode.Open)))
                    {
                        // Loops until end of file
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            double[] numbers = new double[5]; // Array to hold 5 numbers

                            // Reads 5 numbers from file
                            for (int i = 0; i < 5; i++)
                                numbers[i] = reader.ReadDouble();

                            // Reads the average
                            double avg = reader.ReadDouble();

                            // Formats string for display
                            string line = $"Numbers: {string.Join(", ", numbers)} | Average: {avg:F2}";

                            // Adds to ListBox
                            listBoxResults.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handles errors reading file
                MessageBox.Show("Error reading file: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
