/*
 * Program : BankApp
 * Made by Subi
 * Date : 11/10/2025
 * 
 * BankAccount.cs
 * This class defines  a simple bank account class that allows deposits and withdrawals
 * while preventing negative inputs and handling exceptions for invalid operations.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
  
    public class BankAccount
    {
        // Private fields
        private string accountHolder;
        private double balance;

        // Constructor
        public BankAccount ( string aAccountHolder, double aBalance)
        {
            if (aBalance <0)
            {
                throw new NegagtiveException("Initial baLANCE CANNOT BE NEGATIVE ");
            }
            accountHolder = aAccountHolder;
            balance = aBalance; 

        }

        // Property for AccountHolder
        public string AccountHolder
        {
            get
            {
                return accountHolder;
            }
            set
            {
                accountHolder = value;
            }
        }

        // Property for Balance
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        //Deposit Method
        public void Deposit ( double amount)
        {
            if(amount <0)
            {
                throw new NegagtiveException("Deposit amount cannot be negative");
            }

            balance += amount;
        }

        //Withdraw Method
        public void Withdraw(double amount)
        {
            if ( amount <0)
            {
                throw new NegagtiveException("Withdrawal amount cannot be negative");

            }
            if (amount > balance )
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal");
                balance -= amount;

            }
        }

        // ToString override for formatted account info
        public override string ToString()
        {
            return $"Account Holder : {accountHolder}\nCurrent Balance : {balance:C2}";
        }
    }

}
