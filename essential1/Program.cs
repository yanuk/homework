using System;

namespace essential1
{

using System;
using System.ComponentModel;
using System.Dynamic;
            
    class Program
    {
        static void Main(string[] args)
        {
            Address theAddress = new Address();
            
            theAddress.Index = "GU10 3BL";
            theAddress.Country = "UK";
            theAddress.City = "Farnham";
            theAddress.Street = "Frensham Road";
            theAddress.House = "Millbridge";
            theAddress.Apartment = "1";

            Console.WriteLine($" {theAddress.Apartment} {theAddress.House} {Environment.NewLine} {theAddress.Street} {Environment.NewLine} {theAddress.City} {Environment.NewLine} {theAddress.Index} {Environment.NewLine} {theAddress.Country} {Environment.NewLine}");

            Address1 adr = new Address1();

            adr.SetCity("Kiev");
            adr.SetCountry("Ukraine");
            adr.SetStreet("Volynska");
            adr.SetHouse("20");
            adr.SetApartment("4");
            adr.SetIndex("002021");

            Console.WriteLine($" {adr.GetCountry()} {Environment.NewLine} {adr.GetIndex()} {Environment.NewLine} {adr.GetCity()} {Environment.NewLine} {adr.GetStreet()} {adr.GetHouse()} { adr.GetApartment()} {Environment.NewLine} { adr.GetCity()}");
        }
    }
}

