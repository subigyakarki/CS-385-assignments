/*
Program : Housing Application 
Made by Subi
Date : 10/04/2025

SingleFamily.cs
This file defines SingleFamily class which represents individual houses..It inherits from abstract base class housing.

 */

using System.Reflection.Metadata;
using HousingNamespace;

namespace SingleFamilyNamespace

{
    // Single-family housing subclass
    public class SingleFamily : Housing
    {
        private int squareFeet;     // Size in square feet
        private bool hasGarage;     // Garage availability
        private decimal monthlyRent; // Monthly rent

        // Constructor with renamed parameters to avoid 'this'
        public SingleFamily(string aAddress, int aYearBuilt, int aSquareFeet, bool aHasGarage, decimal aMonthlyRent)
            : base(aAddress, aYearBuilt)
        {
            squareFeet = aSquareFeet;
            hasGarage = aHasGarage;
            monthlyRent = aMonthlyRent;
        }

        // Property for Square feet.
        public int SquareFeet
        {
            get
            { 
                return squareFeet; 
            }
            set 
            { 
                squareFeet = value; 
            }
        }

       // Property for Has Garage .
        public bool HasGarage
        {
            get 
            { return hasGarage; 
            }
            set 
            { hasGarage = value; 
            }
        }
        //Property for Monthly rent.
        public decimal MonthlyRent
        {
            get
            { 
                return monthlyRent; 
            }
            set
            { 
                monthlyRent = value;
            }
        }

        // Returns monthly rent for single-family house
        public override decimal ProjectedRentalAmount()
        {
            return monthlyRent;
        }
    }
}
