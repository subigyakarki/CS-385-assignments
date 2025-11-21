/*
Program : Housing Application 
Made by Subi
Date : 10/04/2025

MultiUnits.cs
This files defines multiunit class which represents housing properties that contain multiple rental units. It inherits from housing base class and implements Iunits interface.

 */

using HousingNamespace;
using IUnitsNamespace;

namespace MultiUnitNamespace
{
    // Multi-unit housing subclass implementing IUnits interface
    public class MultiUnit : Housing, IUnits
    {
        private int numberOfUnits;     // Number of units in property
        private decimal monthlyRentPerUnit; // Monthly rent per unit

        // Constructor with renamed parameters to avoid 'this'
        public MultiUnit(string aAddress, int aYearBuilt, int aNumberOfUnits, decimal aMonthlyRentPerUnit)
            : base(aAddress, aYearBuilt)
        {
            numberOfUnits = aNumberOfUnits;
            monthlyRentPerUnit = aMonthlyRentPerUnit;
        }

        // Property for number of Units.
        public int NumberOfUnits
        {
            get 
            {
                return numberOfUnits;
            }
            set
            {
                numberOfUnits = value; 
            }
        }

        // Property for monthly rent per unit.
        public decimal MonthlyRentPerUnit
        {
            get 
            {
                return monthlyRentPerUnit;
            }
            set 
            {
                monthlyRentPerUnit = value; 
            }
        }

        //  Returns the total projected rental amount for all units
        public override decimal ProjectedRentalAmount()
        {
            return numberOfUnits * monthlyRentPerUnit;
        }

        // Method required by IUnits interface
        public int GetNumberOfUnits()
        {
            return numberOfUnits;
        }
    }
}

