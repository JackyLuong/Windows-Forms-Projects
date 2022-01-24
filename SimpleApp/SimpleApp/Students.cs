using System;

namespace SimpleApp
{
    /// <summary>
    /// Represents a product
    /// </summary>
    public class Person
    {
        //private data
        private string fName;
        private string lName;
        private DateTime dateOfBirth;
        // public properties - controlled access to the private data
        #region publicProperties
        public string FName // getter and setter for First Name
        {
            get
            {
                return fName; // get last name
            }
            set 
            {
                if(value == ""  || value == null)
                {
                    fName = "NaN";
                }
                else
                {
                    fName= value; // change the value for first name
                }
            }
        }
        public string LName // getter and setter for Last Name
        {
            get
            {
                return lName; // get last name
            }
            set
            {
                if (value == "" || value == null)
                {
                    lName = "NaN";
                }
                else
                {
                    lName = value; // change the value for last name
                }
            }
        }
        public DateTime DateOfBirth // getter and setter for date of birth
        {
            get
            {
                return dateOfBirth; // get date of birth
            }
            set
            {
                dateOfBirth = value; // change the value of date of birth

                //Check if its within the range of the present date and after 125 years ago
                if (dateOfBirth > DateTime.Today || dateOfBirth.Year < (DateTime.Today.Year - 125))
                {
                    dateOfBirth = DateTime.Today;
                }
            }
        }
        //Display data in console
        public override string ToString()
        {
            return $"First name: {FName}, Last name: {LName}, Birthday: {DateOfBirth.ToLongDateString()}";
        }
        #endregion
    }
}
