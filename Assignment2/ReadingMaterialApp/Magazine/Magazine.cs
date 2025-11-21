/*
Program: Reading Material App
Made by Subi
Date : 10/04/2025

Magazine.cs
This file contains class for magazine that inherits base class Reading Material and implements IPrintable.
 
 */
using System;
using ReadingMaterialNamespace;
using IPrintableNamespace;

namespace MagazineNamespace
{
    //Magazine class inherits ReadingMaterial and implements IPrintable 
    public class Magazine : ReadingMaterial, IPrintable
    {
        private string storeName;


        //Parameterized Constructor
        public Magazine(string aTitle, string aAuthor, int aYearPublished, string aStoreName)
            : base(aTitle, aAuthor, aYearPublished)
        {
            storeName = aStoreName;
        }

        //Default Constructor
        public Magazine()
        {

        }

        // Store name property
        public string StoreName
        {
            set
            {
                storeName = value;
            }
            get
            {
                return storeName;
            }
        }

        //Returns print info
        public string GetPrintInfo()
        {
            return $"Hard copies present at {storeName}";
        }
    }
}
