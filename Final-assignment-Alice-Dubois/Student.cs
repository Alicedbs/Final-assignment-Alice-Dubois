using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_assignment_Alice_Dubois
{
    public class Student : Person
    {
        //Student class, inhereted by Person, composed by the firstname and last of the person class, an address from Adress, age
        //student number, fullname, score, averagescore, and fulladdress.

        private Adress address;
        private string student_number;
        private int age;
        private string full_name;
        private double[] scores;
        private double average_score;
        private string full_address;

        //CONSTRUCTORS
        public Student(string first_name, string last_name, Adress address, string student_number, int age, double[] scores) : base (first_name,last_name)
        {
            this.address = address;
            this.student_number = student_number;
            this.age = age;
            this.scores = scores;

            double sum = 0;
            for (int i = 0; i < scores.Length; i++) 
            {
                 sum += scores[i];
            }
            
            this.average_score = sum / scores.Length;

            this.full_name = first_name + " " + last_name;
            this.full_address = address.ToString(); //use the ToString method from Adress to return the full address.
        }


        //PROPERTIES
        public int Age
        {
            get => age;
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Age have to be between 0 and 100");
                }
            }
        }

        public string Student_number
        {
            get { return student_number; }
        }

        public string Full_name
        {
            get { return full_name; }
            set
            {
                value = full_name;
            }
        }

        public string Full_address
        {
            get { return full_address; }
            set
            {
                value = full_address;
            }
        }

       public double Average_score
        {
            get { return average_score; }
        }

        //METHOD

        //the override ToString method return the elements of the Student class.
        public override string ToString()
        {
            return $"Student's name is {full_name} and is living at the following address : {full_address}" +
                   $"\nStudent's age is {age}\nHis/Her student number is {student_number}" +
                   $"\nAverage score = {average_score} ";
        }

    }
}
