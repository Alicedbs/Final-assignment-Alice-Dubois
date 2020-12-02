using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_assignment_Alice_Dubois
{
    public class Person
    {
        // Person class is composed by the firstname and the lastname.

        private string first_name;
        private string last_name;
        

        //CONSTRUCTORS
        public Person(string first_name, string last_name)
        {
            First_name = first_name;
            Last_name = last_name;
        }


        //PRPOPERTIES
        public string First_name
        {
            get { return first_name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Name cannot be null");
                }

                first_name = value;
            }
        }

        public string Last_name
        {
            get { return last_name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Name cannot be null");
                }

                last_name = value;
            }
        }


        //METHOD

        //the override ToString method return the elements of the Person class.
        public override string ToString()
        {
            return $"The student full name is {First_name} {Last_name}";
        }

    }
}
