/*
Program: Reading Material App
Made by Subi
Date : 10/04/2025

Online.cs
This file contains class for Online that inherits base class ReadingMaterial.

 */
using System;
using ReadingMaterialNamespace;

namespace OnlineNamespace
{
    //Online class inherits ReadingMaterial
    public class Online : ReadingMaterial
    {
        private string websiteURL;

        //Parameterized Constructor
        public Online(string aTitle, string aAuthor, int aYearPublished, string aWebsiteURL)
            : base(aTitle, aAuthor, aYearPublished)
        {
            websiteURL = aWebsiteURL;
        }

        //Default Constructor
        public Online()
        {

        }

       // Website URL property
        public string WebsiteURL
        {
            set
            {
                websiteURL = value;
            }
            get
            {
                return websiteURL;
            }
        }
    }
}

