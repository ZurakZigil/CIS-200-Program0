// Program 0
// CIS 200-01
// By: M9888
// Due: 9/9/2019

// File: Letter.cs
// This class sets up a Letter object that inherits from Parcel. 
// It adds a fixed cost to the object and has a overriden ToString.
// Look into Parcel.cs class for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Letter : Parcel
    {
        private decimal _fixedCost; //Letters will be delivered for a fixed price 

        //Constructor that adopts originAddress and destinationAddress from Parcel and adds fixedCost (in contrast to package)
        public Letter(decimal fixedCost, Address originAddress, Address destinationAddress)
            : base(originAddress, destinationAddress)
        {
            FixedCost = fixedCost;
        }

        // Letters have a flat fixed cost 
        private decimal FixedCost
        {
            // Precondition:  decimal
            // Postcondition: The cost has been returned
            get => _fixedCost;

            // Precondition:  decimal
            // Postcondition: The fixed cost has been set to the specified value
            set
            {
                _fixedCost = value;
            }
        }

        // there is no real calculation to the letters price
        // Precondition:  none
        // Postcondition: The cost has been returned as a fixed cost
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        // ToString is overriden so we can have a custom ToString
        // Precondition:  all included values must be valid
        // Postcondition: a string displayong all the address and cost values is shown
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
