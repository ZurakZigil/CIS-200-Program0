// Program 0
// CIS 200-01
// By: M9888
// Due: 9/9/2019

// File: Address.cs
// This class sets up the Address object.  
// Has a overriden ToString.
// This is in composition with Parcel (and its children Letter and Package).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Address
    {
        // section creates the backing fields for the creation of the address (name to zip)
        private string _name, _address_1, _address_2, _city, _state; // = name, primary address, secondary address, city, state
        private int _zipCode; // = Zip

        int minZip = 0; // min int for zip 
        int maxZip = 99999; // max int for zip

        // Precondition:  Name, Address 1, and City must not be null or empty
        // Postcondition: Address is created with both Address1 & 2
        public Address(string name, string address_1, string address_2, string city, string state, int zipCode)
        {
            Name = name;
            Address1 = address_1;
            Address2 = address_2;
            City = city;
            State = state;
            Zip = zipCode;
        }

        // Precondition:  Name, Address 1, and City must not be null or empty
        // Postcondition: Address is created with just Address1
        public Address(string name, string address_1, string city, string state, int zipCode)
        {
            Name = name;
            Address1 = address_1;
            Address2 = "";
            City = city;
            State = state;
            Zip = zipCode;
        }

        public string Name
        {
            // Precondition:  none
            // Postcondition: The name has been returned
            get => _name;

            // Precondition:  must not be NULL or empty
            // Postcondition: The name has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Name)}", value, $"{nameof(Name)} must not be null or empty"); 
                }
                else _name = value.Trim();
            }
        }
        public string Address1
        {
            // Precondition:  none
            // Postcondition: The address1 has been returned
            get => _address_1;

            // Precondition:  must not be NULL or empty
            // Postcondition: The address1 has been set to the specified value and trimmed
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Address1)}", value, $"{nameof(Address1)} must not be null or empty");
                }
                else _address_1 = value.Trim();
            }
        }
        public string Address2
        {
            // Precondition:  None
            // Postcondition: The address2 has been returned
            get => _address_2;

            // Precondition:  none
            // Postcondition: The address2 has been set to the specified value and trimmed
            set
            {
                _address_2 = value.Trim();
            }
        }
        public string City
        {
            // Precondition:  none
            // Postcondition: The city has been returned
            get => _city;

            // Precondition:  must not be NULL or empty
            // Postcondition: The city has been set to the specified value and trimmed
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(City)}", value, $"{nameof(City)} must not be null or empty"); 
                }
                else _city = value.Trim();
            }
        }
        public string State
        {
            // Precondition:  none
            // Postcondition: The state has been returned
            get => _state;

            // Precondition:  none
            // Postcondition: The state has been set to the specified value and trimmed
            set
            {
                _state = value.Trim();
            }
        }
        public int Zip
        {
            // Precondition:  none
            // Postcondition: The name has been returned
            get => _zipCode;

            // Precondition:  value must be between 0 & 99999
            // Postcondition: The zip has been set to the specified value
            set
            {
                if (value < minZip || value > maxZip ) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Zip)} must be between 0 and 99999.");
                }
                else _zipCode = value;
            }
        }

        // ToString is overriden so we can have a custom ToString
        // Precondition:  all included values must be valid
        // Postcondition: a string displayong all the address values is shown
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Name:              {Name}{NL}" +
                   $"Address 1:         {Address1}{NL}" +
                   $"Address 2:         {Address2}{NL}" +
                   $"City, State Zip:   {City}, {State} {Zip:D5}";
        }

    }

}
