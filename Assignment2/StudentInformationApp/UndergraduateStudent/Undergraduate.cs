/*
Program : Student Information Display
Made By Subi
Date: 10/06/25

Undergraduate,cs
This file has class for Undergraduate which inherits from base Student .

 */
using System;
using StudentNamespace; // Reference to Student

namespace UndergraduateStudentNamespace
{
    public class UndergraduateStudent : Student
    {
        private string classification;
        private string guardianName;
        private string guardianAddress;

        // Parameterized constructor
        public UndergraduateStudent(string aId, string aName, string aMajor, string aClassification, string aGuardianName, string aGuardianAddress)
            : base(aId, aName, aMajor)
        {
            classification = aClassification;
            guardianName = aGuardianName;
            guardianAddress = aGuardianAddress;
        }

        // Default constructor
        public UndergraduateStudent()
        {
        }

        // Classification property
        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }

        // GuardianName property
        public string GuardianName
        {
            get
            {
                return guardianName; 
            }
            set 
            {
                guardianName = value; 
            }
        }

        // GuardianAddress property
        public string GuardianAddress
        {
            get
            {
                return guardianAddress;
            }
            set
            {
                guardianAddress = value;
            }
        }

        // ToString override
        public override string ToString()
        {
            return $"{base.ToString()}, Classification: {Classification}, Guardian: {GuardianName}, Address: {GuardianAddress}";
        }
    }
}
