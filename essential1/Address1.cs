namespace essential1
{
    using System;
    using System.ComponentModel;
    using System.Dynamic;
    public class Address1
    {
        private string index = null, country = null, city = null, street = null, house = null, apartment = null;
        public void SetIndex(string value)
        {
            index = value;
        }
        public void SetCountry(string value)
        {
            country = value;
        }
        public void SetCity(string value)
        {
            city = value;
        }
        public void SetStreet(string value)
        {
            street = value;
        }
        public void SetHouse(string value)
        {
            house = value;
        }
        public void SetApartment(string value)
        {
            apartment = value;
        }
        public string GetApartment()
        {
            return (apartment);
        }
        public string GetHouse()
        {
            return (house);
        }
        public string GetCity()
        {
            return (city);
        }
        public string GetIndex()
        {
            return (index);
        }
        public string GetStreet()
        {
            return (street);
        }
        public string GetCountry()
        {
            return (country);
        }
    }
}