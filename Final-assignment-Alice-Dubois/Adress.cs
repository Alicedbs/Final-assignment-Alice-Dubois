using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_assignment_Alice_Dubois
{
    public class Adress
    {
        // Address class is composed by the number of the location, the street name, the city and the country.

        private int number;
        private string street;
        private string city;
        private string country;


        //CONSTRUCTORS
        public Adress(int number, string street, string city, string country)
        {
            this.number = number;
            this.street = street;
            this.city = city;
            this.country = country;
        }


        //PROPERTIES
        public int Number
        {
            get => number;
            set
            {
                if (number > 0 )
                {
                    number = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Number can not be negative");
                }
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Street cannot be null");
                }

                street = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("city cannot be null");
                }

                city = value;
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Country cannot be null");
                }

                country = value;
            }
        }


        //METHOD

        //the override ToString method return the elements of the Address class.
        public override string ToString()
        {
            return $"{Number}, {Street} in {City}, {Country}";
        }
    }
}
