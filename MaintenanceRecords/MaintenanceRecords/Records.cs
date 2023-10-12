//Author: Josh Werlein
//Purpose: Create an application that tracks maintenance to vehicles by owner
//Date: 10/08/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaintenanceRecords
{
    internal class Records
    {
        // Define class level variables
        private int mOwnerID;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private string mPhoneNumber;
        private DateTime mRegistrationDate;
        private string mMake;
        private string mModel;
        private int mYear;
        private string mColor;
        private string mVin;
        private string mLicensePlate;
        private int mOdometer;
        private decimal mCost;
        private string mNotes;
        private string mService;
        private DateTime mServiceDate;

        // Get and set variable values
        public int OwnerID { get { return mOwnerID; } set { mOwnerID = value; } }
        public string FirstName { get { return mFirstName; } set { mFirstName = value; } }
        public string LastName { get { return mLastName; } set { mLastName = value; } }
        public string Email { get { return mEmail; } set { mEmail = value; } }
        public string PhoneNumber { get { return mPhoneNumber; } set { mPhoneNumber = value; } }
        public DateTime RegistrationDate { get { return mRegistrationDate; } set { mRegistrationDate = value; } }
        public string Make { get { return mMake; } set { mMake = value; } }
        public string Model { get { return mModel; } set { mModel = value; } }
        public int Year { get { return mYear; } set { mYear = value; } }
        public string Color { get { return mColor; } set { mColor = value; } }
        public string Vin { get { return mVin; } set { mVin = value; } }
        public string LicensePlate { get { return mLicensePlate; } set { mLicensePlate = value; } }
        public int Odometer { get { return mOdometer; } set { mOdometer = value; } }
        public decimal Cost { get { return mCost; } set { mCost = value; } }
        public string Notes { get { return mNotes; } set { mNotes = value; } }
        public string Service { get { return mService; } set { mService = value; } }
        public DateTime ServiceDate { get { return mServiceDate; } set { mServiceDate = value; } }

        // Property for returning full name
        public string FullName => mFirstName + " " + mLastName;

        // Default constructor
        public Records()
        {
            this.mOwnerID = 0;
            this.mFirstName = string.Empty;
            this.mLastName = string.Empty;
            this.mEmail = string.Empty;
            this.mPhoneNumber = string.Empty;
            this.mRegistrationDate = new DateTime(1901, 01, 01);
            this.mMake = string.Empty;
            this.mModel = string.Empty;
            this.mYear = 0;
            this.mColor = string.Empty;
            this.mVin = string.Empty;
            this.mLicensePlate = string.Empty;
            this.mOdometer = 0;
            this.mCost = 0;
            this.mNotes = string.Empty;
            this.mService = string.Empty;
            this.mServiceDate = new DateTime(1901, 01, 01);
        }

        // Overloaded contructor
        public Records(string firstName, string lastName)
        {
            this.mFirstName = firstName;
            this.mOwnerID = 0;
            this.mLastName = lastName;
            this.mEmail = string.Empty;
            this.mPhoneNumber = string.Empty;
            this.mRegistrationDate = new DateTime(1901, 01, 01);
        }

        // Overloaded constructor for UserID
        public Records(int OwnerID)
        {
            mOwnerID = OwnerID;
            this.mFirstName = string.Empty;
            this.mLastName = string.Empty;
            this.mEmail = string.Empty;
            this.mPhoneNumber = string.Empty;
            this.mRegistrationDate = new DateTime(1901, 01, 01);
            this.mMake = string.Empty;
            this.mModel = string.Empty;
            this.mYear = 0;
            this.mColor = string.Empty;
            this.mVin = string.Empty;
            this.mLicensePlate = string.Empty;
            this.mOdometer = 0;
            this.mCost = 0;
            this.mNotes = string.Empty;
            this.mService = string.Empty;
            this.mServiceDate = new DateTime(1901, 01, 01);
        }
    }
}
