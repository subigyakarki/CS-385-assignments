/*
Program: Reading Material App
Made by Subi
Date : 10/04/2025

ReadingMaterial.cs
This file has the base class ReadingMaterial that contain common characteristics like title, author and year published.
 */
using System;

namespace ReadingMaterialNamespace
{
    // Base class for all reading materials
    public abstract class ReadingMaterial
    {
        private string title;
        private string author;
        private int yearPublished;

        //Constructor with parameters
        public ReadingMaterial(string aTitle, string aAuthor, int aYearPublished)
        {
            title = aTitle;
            author = aAuthor;
            yearPublished = aYearPublished;
        }

        //Default Constructor
        public ReadingMaterial()
        {
        }

        //Title property
        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }

        //Author Property
        public string Author
        {
            set
            {
                author = value;
            }
            get
            {
                return author;
            }
        }

        //Year Published Property
        public int YearPublished
        {
            set
            {
                yearPublished = value;
            }
            get
            {
                return yearPublished;
            }
        }
    }
}