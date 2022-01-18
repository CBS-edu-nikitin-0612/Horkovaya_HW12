using System;

namespace Task6
{
    class Adress
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;
        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.Index = Console.ReadLine();
            adress.Country = Console.ReadLine();
            adress.City = Console.ReadLine();
            adress.Street = Console.ReadLine();
            adress.House = Convert.ToInt32(Console.ReadLine());
            adress.Apartment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Index: {0}\nCountry: {1}\nCity: {2}\nStreet: {3}\nHouse:{4}\nApartment: {5}", adress.Index, adress.Country,
                adress.City, adress.Street, adress.House, adress.Apartment);
        }
    }
}
