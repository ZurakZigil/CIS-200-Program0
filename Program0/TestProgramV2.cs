// Program 0
// CIS 200-01
// By: M9888
// Due: 9/9/2019

// File: TestProgramV2.cs (rename later)
// This class's prupose is to test our classes for erros.
// will later be used to enter in custom data.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class TestProgramV2
    {
        // Precondition:  none
        // Postcondition: the pre-maid shippment objects are displayed
        static void Main(string[] args)
        {
            Address ad1 = new Address("name", "address_1", "address_2", "city", "state", 99999); //test address 1
            Address ad2 = new Address("Joe", "123 The Street", "wut", "NYC", "NY", 12345); //test address 2
            Address ad3 = new Address("Dr. Wright", "I dont know where you live", "Louisville", "KY", 40217); //test address 3
            Address ad4 = new Address("'Ol McDonald", "had a farm", "                           eee eye eee eye", "Farmville", "T E X A S", 5); //test address 4

            //List to utilize the addresses above and allows us to decalre a price
            List<Parcel> parcelList = new List<Parcel>()
            {
                new Letter (5, ad1, ad2), //Letter 1
                new Letter (17, ad3, ad4), //Letter 2
                new Letter (0.25M, ad4, ad2) //Letter 3
            };


            string NL = Environment.NewLine; // NewLine shortcut

            //goes through each item in the  parcelList and displays the ToString declared in Letter:Parcel
            foreach (var parcelItem in parcelList)
            {
                Console.WriteLine($"{parcelItem.ToString()}{NL}");
                Console.Write("Press Enter to continue..."); // just to insure readability
                Console.ReadLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1); // Stackoverflow
                ClearCurrentConsoleLine(); // Stackoverflow
                Console.WriteLine($"{NL}");
            }
        }

        // Was not required, but aesthetically made te program better.
        // https://stackoverflow.com/questions/8946808/can-console-clear-be-used-to-only-clear-a-line-instead-of-whole-console
        // Precondition: None
        // Postcondition: Set cursor to certain position then clears the line
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
