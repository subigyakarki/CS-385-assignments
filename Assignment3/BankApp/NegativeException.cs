/*
 * Program : BankApp
 * Made by Subi
 * Date : 11/10/2025
 * 
 * NegativeException.cs
 * This class defines a custom exception called NegativeException, which
 * inherits from ApplicationException. It is used to handle cases where
 * a negative value is entered for deposits, withdrawals, or initial balance.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    // Custom exception class for negative values
    public class NegagtiveException : ApplicationException
    {
        // Constructor that passes message to the base ApplicationException
        public NegagtiveException(string message) : base(message)
        {
        }
    }
}
