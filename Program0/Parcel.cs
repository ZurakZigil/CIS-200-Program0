// Program 0
// CIS 200-01
// By: M9888
// Due: 9/9/2019

// File: Parcel.cs
// This class creates a Parcel object. 
// It is the parent class of Letter and Package.
// It uses the Address class to have 2 address (To and From) for when shipping.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class Parcel
    {
        // section creates the backing fields for the creation of the to and from addresses
        private Address _originAddress, _destinationAddress;

        // Precondition:  Name, Address 1, and City must not be null or empty in either address
        // Postcondition: the to and from Addresses are created
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        public Address OriginAddress
        {
            // Precondition:  none
            // Postcondition: The origin address has been returned
            get => _originAddress;

            // Precondition:  Name, Address 1, and City must not be null
            // Postcondition: The origin address has been set to the specified value
            set
            {
                 _originAddress = value;
            }
        }
        public Address DestinationAddress
        {
            // Precondition:  none
            // Postcondition: The destination address has been returned
            get => _destinationAddress;

            // Precondition:  Name, Address 1, and City must not be null
            // Postcondition: The destination address has been set to the specified value
            set
            {
                _destinationAddress = value;
            }
        }

        public abstract decimal CalcCost();

        // ToString is overriden so we can have a custom ToString
        // Precondition:  all included values must be valid
        // Postcondition: a string displayong all the addresses and cost values is shown
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"FROM:{NL}" +
                $"{OriginAddress.ToString()} {NL}{NL}" +
                $"TO:{NL}" +
                $"{DestinationAddress.ToString()} {NL}" +
                $"----------------{NL}" +
                $"COST: {CalcCost():C}";
        }
    }
}
