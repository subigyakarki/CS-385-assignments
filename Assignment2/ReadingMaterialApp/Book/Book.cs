/*
Program: Reading Material App
Made by Subi
Date : 10/04/2025

Book.cs
This file contains class for books that inherits base class Reading Material and implements interface IPrintable.
*/
using System;
using ReadingMaterialNamespace;
using IPrintableNamespace;

namespace BookNamespace
{
    //Book class inherits ReadingMaterial and implements IPrintable
    public class Book : ReadingMaterial, IPrintable
    {
        private string publisher;

        //Parameterized Constructor
        public Book(string aTitle, string aAuthor, int aYearPublished, string aPublisher)
            : base(aTitle, aAuthor, aYearPublished)
        {
            publisher = aPublisher;
        }

        //Default Constructor
        public Book()
        {
        }

        //Publisher Property
        public string Publisher
        {
            set
            {
                publisher = value;
            }
            get
            {
                return publisher;
            }
        }

        //Returns print info
        public string GetPrintInfo()
        {
            return $"Printable PDF from publisher {publisher}";
        }
    }
}
