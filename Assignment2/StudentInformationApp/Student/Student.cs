/*
Program : Student Information Display
Made By Subi
Date: 10/06/25

Student.cs
This file defines the abstract base class Student which has common characteristics like ID, Name  and major.
 */using System;

namespace StudentNamespace
{
    public abstract class Student
    {
        private string id;
        private string name;
        private string major;

        // Parameterized constructor
        public Student(string aId, string aName, string aMajor)
        {
            id = aId;
            name = aName;
            major = aMajor;
        }

        // Default constructor
        public Student()
        {
        }

        // ID property
        public string ID
        {
            get
            {
                return id; 
            }
            set
            { 
                id = value; 
            }
        }

        // Name property
        public string Name
        {
            get 
            { 
                return name;
            }
            set 
            {
                name = value; 
            }
        }

        // Major property
        public string Major
        {
            get
            {
                return major; 
            }
            set
            { 
                major = value;
            }
        }

        // ToString method
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Major: {Major}";
        }
    }
}
