/*
 Program: Pizza Delivery Application
 Made 
 Date:09/28/2025
 This program creates a pizza ordering system fora pizza delivery company. Users can select pizza
 size, crust type, sauce, toppings, sides, and drinks.The program calculates the total price and displays
 a detailed order summary including customer info.
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

namespace PizzaCompanyDeliveryApp
{
    public partial class PizzaDeliveryApp : Form
    {
        public PizzaDeliveryApp()
        {
            InitializeComponent();
        }

        // Event handler for Place Order button click
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double totalPrice = 0; // Stores total order price

            //Calculate Pizza Size Price 
            if (radPizzaSizeMini.Checked)
                totalPrice = 7;
            else if (radPizzaSizeSmall.Checked)
                totalPrice = 9;
            else if (radPizzaSizeMedium.Checked)
                totalPrice = 11;
            else if (radPizzaSizeLarge.Checked)
                totalPrice = 13;
            else if (radPizzaSizeExtraLarge.Checked)
                totalPrice = 15;

            //Calculate Toppings Price
            if (radPizzaToppingsSpecial.Checked)
            {
                totalPrice += 7; // Fixed price for Soobi’s Special
            }
            else
            {
                totalPrice += lstBxMeat.SelectedItems.Count * 3;
                totalPrice += lstBxVeggies.SelectedItems.Count * 2;
                totalPrice += lstBxCheese.SelectedItems.Count * 3;
            }

            // Calculate Drinks Price
            totalPrice += lstBxSoda.SelectedItems.Count * 3;
            totalPrice += lstBxJuice.SelectedItems.Count * 2;

            //Calculate Sides Price
            if (radSidesSalad.Checked || radSidesWings.Checked || radSidesMozarella.Checked ||
                radSidesGarlicBread.Checked || radSidesOnionRings.Checked || radSidesWedges.Checked)
            {
                totalPrice += 5;
            }

            // Build Order Summary
            lblOrderSummary.Text = ""; // Clear previous summary

            // Customer Information
            lblOrderSummary.Text += "-------------Customer Information-------------\n";
            lblOrderSummary.Text += $"Name: {txtName.Text}\n";
            lblOrderSummary.Text += $"Address: {txtAddress.Text}\n";
            lblOrderSummary.Text += $"Phone: {txtPhone.Text}\n";
            lblOrderSummary.Text += $"Email: {txtEmail.Text}\n\n";

            // Order Information
            lblOrderSummary.Text += "-------------------------Order-------------------------\n";

            // Pizza Size
            lblOrderSummary.Text += "Pizza Size: ";
            if (radPizzaSizeMini.Checked) lblOrderSummary.Text += "Mini\n";
            else if (radPizzaSizeSmall.Checked) lblOrderSummary.Text += "Small\n";
            else if (radPizzaSizeMedium.Checked) lblOrderSummary.Text += "Medium\n";
            else if (radPizzaSizeLarge.Checked) lblOrderSummary.Text += "Large\n";
            else if (radPizzaSizeExtraLarge.Checked) lblOrderSummary.Text += "Extra Large\n";

            // Crust
            lblOrderSummary.Text += "Crust: ";
            if (radPizzaCrustNewYork.Checked) lblOrderSummary.Text += "New York Style\n";
            else if (radPizzaCrustCrunchyThin.Checked) lblOrderSummary.Text += "Crunchy Thin\n";
            else if (radPizzaCrustHandmadePan.Checked) lblOrderSummary.Text += "Handmade Pan\n";
            else if (radPizzaCrustHandTossed.Checked) lblOrderSummary.Text += "Hand Tossed\n";
            else if (radPizzaCrustCheesy.Checked) lblOrderSummary.Text += "Cheesy\n";
            else if (radPizzaCrustGlutenFree.Checked) lblOrderSummary.Text += "Gluten Free\n";

            // Sauce
            lblOrderSummary.Text += "Sauce: ";
            if (radPizzaSauceSoobis.Checked) lblOrderSummary.Text += "Soobi's Special Sauce\n";
            else if (radPizzaSauceBuffalo.Checked) lblOrderSummary.Text += "Buffalo\n";
            else if (radPizzaSauceBBQ.Checked) lblOrderSummary.Text += "BBQ\n";
            else if (radPizzaSauceGarliNOlive.Checked) lblOrderSummary.Text += "Garlic & Olive Oil\n";
            else if (radPizzaSauceNeopolitan.Checked) lblOrderSummary.Text += "Neopolitan\n";
            else if (radPizzaSauceMarinara.Checked) lblOrderSummary.Text += "Marinara\n";

            // Toppings
            lblOrderSummary.Text += "Toppings:\n";
            if (radPizzaToppingsSpecial.Checked)
            {
                lblOrderSummary.Text += "*Special: Soobi’s Special";
            }
            else
            {
                lblOrderSummary.Text += "Meats: ";
                for (int i = 0; i < lstBxMeat.SelectedItems.Count; i++)
                    lblOrderSummary.Text += lstBxMeat.SelectedItems[i].ToString() + " , ";

                lblOrderSummary.Text += "\nVeggies: ";
                for (int i = 0; i < lstBxVeggies.SelectedItems.Count; i++)
                    lblOrderSummary.Text += lstBxVeggies.SelectedItems[i].ToString() + ",";

                lblOrderSummary.Text += "\nCheeses: ";
                for (int i = 0; i < lstBxCheese.SelectedItems.Count; i++)
                    lblOrderSummary.Text += lstBxCheese.SelectedItems[i].ToString() + ",";
            }

            // Sides
            lblOrderSummary.Text += "\nSides: ";
            if (radSidesSalad.Checked) lblOrderSummary.Text += "Salad ";
            if (radSidesWings.Checked) lblOrderSummary.Text += "Wings ";
            if (radSidesMozarella.Checked) lblOrderSummary.Text += "Mozarella ";
            if (radSidesGarlicBread.Checked) lblOrderSummary.Text += "Garlic Bread ";
            if (radSidesOnionRings.Checked) lblOrderSummary.Text += "Onion Rings ";
            if (radSidesWedges.Checked) lblOrderSummary.Text += "Wedges ";

            // Drinks
            lblOrderSummary.Text += "\nSodas: ";
            for (int i = 0; i < lstBxSoda.SelectedItems.Count; i++)
                lblOrderSummary.Text += lstBxSoda.SelectedItems[i].ToString() + " ";

            lblOrderSummary.Text += "\nJuices: ";
            for (int i = 0; i < lstBxJuice.SelectedItems.Count; i++)
                lblOrderSummary.Text += lstBxJuice.SelectedItems[i].ToString() + " ";

            lblOrderSummary.Text += "\nWater: ";
            lblOrderSummary.Text += radDrinksWater.Checked ? "Yes" : "No";

            // Total Price
            lblOrderSummary.Text += $"\n\nTotal Price: ${totalPrice}";
        }

        // Clear all inputs and reset form
        private void bttnClearOrder_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            radPizzaSizeMini.Checked = false;
            radPizzaSizeSmall.Checked = false;
            radPizzaSizeMedium.Checked = false;
            radPizzaSizeLarge.Checked = false;
            radPizzaSizeExtraLarge.Checked = false;

            radPizzaCrustNewYork.Checked = false;
            radPizzaCrustCrunchyThin.Checked = false;
            radPizzaCrustHandmadePan.Checked = false;
            radPizzaCrustHandTossed.Checked = false;
            radPizzaCrustCheesy.Checked = false;
            radPizzaCrustGlutenFree.Checked = false;

            radPizzaSauceSoobis.Checked = false;
            radPizzaSauceBuffalo.Checked = false;
            radPizzaSauceBBQ.Checked = false;
            radPizzaSauceGarliNOlive.Checked = false;
            radPizzaSauceNeopolitan.Checked = false;
            radPizzaSauceMarinara.Checked = false;

            radSidesSalad.Checked = false;
            radSidesWings.Checked = false;
            radSidesMozarella.Checked = false;
            radSidesGarlicBread.Checked = false;
            radSidesOnionRings.Checked = false;
            radSidesWedges.Checked = false;

            radDrinksWater.Checked = false;
            radPizzaToppingsSpecial.Checked = false;

            lstBxMeat.ClearSelected();
            lstBxVeggies.ClearSelected();
            lstBxCheese.ClearSelected();
            lstBxSoda.ClearSelected();
            lstBxJuice.ClearSelected();

            lblOrderSummary.Text = "";
        }

        // Exit the application
        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
