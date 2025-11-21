/*
 Made by Subi
 Program: Inspirational Message Displayer
 Date: 09/28/2025
 This application displays inspirational messages selected by the user.
 Users can add their own sayings, change text color, change font, and view about info.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspirationalMessageApp
{
    public partial class InspirationalMessageApp : Form
    {
        // Constructor 
        public InspirationalMessageApp()
        {
            InitializeComponent(); // Initialize the form controls
        }

        // Event for when the user selects a different item in the ComboBox
        private void cmbSayings_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = cmbSayings.Text; // Display the selected saying in the label
        }

        // Event for when the text in the ComboBox changes
        private void cmbSayings_TextChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = cmbSayings.Text; // Update label text with ComboBox text
        }

        // Event for exit menu click 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        // Event for colour menu click which opens a colour picker dialog
        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) // If user chooses a colour
            {
                lblDisplay.ForeColor = colorDialog1.Color; // Change label text colour
            }
        }

        // Event for font menu click which opens a font selection dialog
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) // If user chooses a font
            {
                lblDisplay.Font = fontDialog1.Font; // Change label font style
            }
        }

        // Event for about menu click which shows app information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Inspirational Message Displayer\nFeel free to add the quotes that inspire you :)\nCreated by Subi",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Event for when a key is pressed in the ComboBox
        private void cmbSayings_KeyDown(object sender, KeyEventArgs e)
        {
            // If Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                string newSaying = cmbSayings.Text.Trim(); // Get the typed text

                // If text is not empty and is not already in the list then add it
                if (!string.IsNullOrEmpty(newSaying) && !cmbSayings.Items.Contains(newSaying))
                {
                    cmbSayings.Items.Add(newSaying);
                }

                lblDisplay.Text = newSaying; // Show new saying in the label


            }
        }
    }
}
