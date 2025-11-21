/*
 * Program : BankApp
 * Made by Subi
 * Date : 11/10/2025
 * 
 * Program.cs
 * This is the main driver class for the SafeBank application.It demonstrates exception handling, user input validation,
 * and interaction with the BankAccount class.
 */
using System;
using System.Diagnostics;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("------- Welcome to Norio Bank Limited -------");
                Console.WriteLine("______________________________________________");

                // Ask for account holder name
                Console.Write("Enter account holder name: ");
                string name = Console.ReadLine();


                // Validate initial deposit input
                Console.Write("Enter initial deposit: ");
                double initial = double.Parse(Console.ReadLine());

                // Create bank account
                BankAccount account = new BankAccount(name, initial);
                Console.WriteLine("\nAccount successfully created!");
                Console.WriteLine(account);

                // Deposit operation
                Console.Write("\nEnter amount to deposit: ");
                double depositAmount = double.Parse(Console.ReadLine());
                account.Deposit(depositAmount);
                Console.WriteLine("Deposit successful.");
                Console.WriteLine(account);

                // Withdrawal operation
                Console.Write("\nEnter amount to withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawAmount);
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine(account);
            }

            // Custom exception for negative inputs
            catch (NegagtiveException ex)
            {
                Console.WriteLine("\n[Error] " + ex.Message);
                Trace.WriteLine("Negative value error: " + ex.Message);
            }

            
            // Exception for non-numeric inputs
            catch (FormatException ex)
            {
                Console.WriteLine("\n[Error] Invalid numeric format.");
                Trace.WriteLine("Format error: " + ex.Message);
            }

            // Catch-all for any unexpected errors that might occur
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\n[Error] " + ex.Message);
                Trace.WriteLine("Invalid operation: " + ex.Message);
            }

            // Catch-all for any unexpected errors that might occur
            catch (Exception ex)
            {
                Console.WriteLine("\n[General Error] " + ex.Message);
                Trace.WriteLine("Unhandled exception: " + ex.Message);
            }

            // Final Block
            finally
            {
                Console.WriteLine("\nThank you for using Norio Bank Limited.  Hope you have a wonderful day ahead !!! :) ");
            }
        }
    }
}
