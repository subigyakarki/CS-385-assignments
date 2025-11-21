/*
Program : Housing Application 
Made by Subi
Date : 10/04/2025


PresentationGUI.cs
This is files defines the Windows form presentation class that tests the Housing, MultiUnit, SingleFamily classes. 
It allows the user to enter the property information, select housing type and display the projected amount.
 
 
 */


using System;
using System.Windows.Forms;
using HousingNamespace;      //Imports abstract base class Housing.
using IUnitsNamespace;       //Imports Iunits interface.
using MultiUnitNamespace;    //Imports MultiUnit class.
using SingleFamilyNamespace; //Imports Single Family class.

namespace PresentationGUI
{
    //Main GUI for Housing Application
    public partial class PresentationGUI : Form
    {

        //Constructor
        public PresentationGUI()
        {
            InitializeComponent();

            //Attach event handles to UI controls

            radioButtonSingleFamily.CheckedChanged += RadioButtonHousingTypeChanged;
            radioButtonMultiUnit.CheckedChanged += RadioButtonHousingTypeChanged;
            buttonCalculate.Click += ButtonCalculate_Click;

            //Sets default state of the controls.
            RadioButtonHousingTypeChanged(null, null);
        }

        //Enables and Disables fields based on selected housinhg types.
        private void RadioButtonHousingTypeChanged(object sender, EventArgs e)
        {
            bool isSingleFamily = radioButtonSingleFamily.Checked;

            textBoxSquareFeet.Enabled = isSingleFamily;
            checkBoxGarage.Enabled = isSingleFamily;

            textBoxNumofUnits.Enabled = radioButtonMultiUnit.Checked;
        }

        //Event Handler for calculate button
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            decimal projectedRent = 0m;

            //Handles single family housing
            if (radioButtonSingleFamily.Checked)
            {
                if (int.TryParse(textBoxYearBuilt.Text, out int yearBuilt) &&
                    int.TryParse(textBoxSquareFeet.Text, out int squareFeet) &&
                    decimal.TryParse(Rent.Text, out decimal rent))
                {
                    SingleFamily singleFamily = new SingleFamily(
                        textBoxAddress.Text,
                        yearBuilt,
                        squareFeet,
                        checkBoxGarage.Checked,
                        rent
                    );

                    projectedRent = singleFamily.ProjectedRentalAmount();
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values.", "Input Error");
                    return;
                }
            }

            //Handles Multi-Unit housing
            else if (radioButtonMultiUnit.Checked)
            {
                if (int.TryParse(textBoxYearBuilt.Text, out int yearBuilt) &&
                    int.TryParse(textBoxNumofUnits.Text, out int numUnits) &&
                    decimal.TryParse(Rent.Text, out decimal rent))
                {
                    MultiUnit multiUnit = new MultiUnit(
                        textBoxAddress.Text,
                        yearBuilt,
                        numUnits,
                        rent
                    );

                    projectedRent = multiUnit.ProjectedRentalAmount();
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values.", "Input Error");
                    return;
                }
            }

            //Displays the result.
            textBoxProjectedRent.Text = projectedRent.ToString("C");
        }
    }
}


