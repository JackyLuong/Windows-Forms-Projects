using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    /// <summary>
    /// Contains information about a person
    /// </summary>
    class Person
    {
        // private fields
        private string firstName, lastName;
        private DateTime birthDate;

        // property accessors
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value == "" || value == null)
                    throw new FormatException("First name can't be empty or null");

                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value == "" || value == null)
                    throw new FormatException("Last name can't be empty or null");

                lastName = value;
            }
        }
        public DateTime BirthDate
        { 
            get
            {
                return birthDate;
            }
            set
            {
                DateTime today = DateTime.Today;

                // Check if they're born within the past 125 years, or throw
                // an exception
                if (today.Year - value.Year > 125 || today.Year - value.Year < 0)
                    throw new FormatException("Birth date must be within the last 125 years!");

                birthDate = value;
            }
        }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            // run setters
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        /// <summary>
        /// Overrides built-in ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName}, DOB: {BirthDate.ToLongDateString()}";
        }
    }
}
