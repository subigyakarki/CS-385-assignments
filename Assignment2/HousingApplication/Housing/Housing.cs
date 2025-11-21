/*
Program : Housing Application 
Made by Subi
Date : 10/04/2025

Housing.cs
This files defines the Abstract base class which stores common data characteristics.

 */
using System;

namespace HousingNamespace
{
    // Abstract base class for all housing types
    public abstract class Housing
    {
        private string address;   // Property for housing address
        private int yearBuilt;    // Year the property was built

        // Constructor with renamed parameters to avoid 'this'
        public Housing(string aAddress, int aYearBuilt)
        {
            address = aAddress;
            yearBuilt = aYearBuilt;
        }

        // Property for Address
        public string Address
        {
            get
            { 
                return address; 
            }
            set
            { 
                address = value; 
            }
        }

        // Property for Year Built
        public int YearBuilt
        {
            get
            {
                return yearBuilt; 
            }
            set 
            { yearBuilt = value;
            }
        }

        // Abstract method to calculate projected rental amount
        public abstract decimal ProjectedRentalAmount();
    }
}


