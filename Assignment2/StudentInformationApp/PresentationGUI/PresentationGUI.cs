/* 
Program : Student Information Display
Made By Subi
Date: 10/06/25

PresentationGUI.cs
Demonstrates inheritance and polymorphism with Student, GraduateStudent, and UndergraduateStudent classes with a GUI.
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GraduateStudentNamespace;          // GraduateStudent class
using StudentNamespace;                  // Student base class
using UndergraduateStudentNamespace;     // UndergraduateStudent class

namespace PresentationGUI
{
    // Main form for student input and display
    public partial class PresentationGUI : Form
    {
        // Constructor: initialize form and events
        public PresentationGUI()
        {
            InitializeComponent();

            // Event handlers for radio buttons and add button
            radGraduate.CheckedChanged += StudentTypeChanged;
            radUnderGraduate.CheckedChanged += StudentTypeChanged;
            buttonAddStudent.Click += buttonAddStudent_Click;

            UpdateVisibleFields(); // set initial field visibility
        }

        // Event handler to update visible fields when student type changes
        private void StudentTypeChanged(object sender, EventArgs e)
        {
            UpdateVisibleFields();
        }

        // Shows/hides form fields based on student type
        private void UpdateVisibleFields()
        {
            bool isGraduate = radGraduate.Checked;

            // Graduate-specific fields
            labelUGDegree.Visible = textBoxUGDegree.Visible = isGraduate;
            labelInstituion.Visible = textBoxInstitution.Visible = isGraduate;

            // Undergraduate-specific fields
            labelClassification.Visible = textBoxClassification.Visible =
            labelGuardianName.Visible = textBoxGuardianName.Visible =
            labelGuardianAddress.Visible = textBoxGuardianAddress.Visible = !isGraduate;
        }

        // Event handler for adding student
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Student student;

            if (radGraduate.Checked)
            {
                // Create GraduateStudent object
                student = new GraduateStudent(
                    textBoxID.Text,
                    textBoxName.Text,
                    textBoxMajor.Text,
                    textBoxUGDegree.Text,
                    textBoxInstitution.Text
                );
            }
            else
            {
                // Create UndergraduateStudent object
                student = new UndergraduateStudent(
                    textBoxID.Text,
                    textBoxName.Text,
                    textBoxMajor.Text,
                    textBoxClassification.Text,
                    textBoxGuardianName.Text,
                    textBoxGuardianAddress.Text
                );
            }

            // Display student details in textbox
            textBox2.Text = GetStudentDetails(student);
        }

        // Formats student details as a string
        private string GetStudentDetails(Student student)
        {
            string details = $"ID: {student.ID}\r\n" +
                             $"Name: {student.Name}\r\n" +
                             $"Major: {student.Major}\r\n";

            if (student is GraduateStudent grad)
            {
                details += $"Undergraduate Degree: {grad.UndergraduateDegree}\r\n" +
                           $"Institution: {grad.Institution}\r\n";
            }
            else if (student is UndergraduateStudent undergrad)
            {
                details += $"Classification: {undergrad.Classification}\r\n" +
                           $"Guardian Name: {undergrad.GuardianName}\r\n" +
                           $"Guardian Address: {undergrad.GuardianAddress}\r\n";
            }

            return details;
        }
    }
}
