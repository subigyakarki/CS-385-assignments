/*
 Program : Student Information Display
Made By Subi
Date: 10/06/25

Graduate.cs
This file has class for Graduate which inherits from base Student .
*/
using System;
using StudentNamespace; // Reference to Student

namespace GraduateStudentNamespace
{
    public class GraduateStudent : Student
    {
        private string undergraduateDegree;
        private string institution;

        // Parameterized constructor
        public GraduateStudent(string aId, string aName, string aMajor, string aDegree, string aInstitution)
            : base(aId, aName, aMajor)
        {
            undergraduateDegree = aDegree;
            institution = aInstitution;
        }

        // Default constructor
        public GraduateStudent()
        {
        }

        // UndergraduateDegree property
        public string UndergraduateDegree
        {
            get
            { 
                return undergraduateDegree;
            }
            set 
            { 
                undergraduateDegree = value; 
            }
        }

        // Institution property
        public string Institution
        {
            get
            {
                return institution;
            }
            set
            {
                institution = value; 
            }
        }

        // ToString override
        public override string ToString()
        {
            return $"{base.ToString()}, Degree: {UndergraduateDegree}, Institution: {Institution}";
        }
    }
}
