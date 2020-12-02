using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_assignment_Alice_Dubois
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    break;
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            display_message();
                            break;

                        case "2":
                            new_person();
                            break;
                    }
                }
            }
            Console.ReadKey();
        }


        //new_person is a method where a person is already create and return the ToString method of the Student class.
        private static void new_person()
        {
            double[] score1 = { 5, 8, 9, 8, 7 };
            Adress address1 = new Adress(9, "french street", "Paris", "France");
            Student person1 = new Student("Alice", "Dubois", address1, "VER652", 20, score1);
            Console.WriteLine(person1);
            Console.ReadKey();
        }


        //display_message is a method that asks questions to the user and return and calculate datas about the student.
        private static void display_message()
        {
            Console.WriteLine("- Please enter your first name : ");
            string first_name1 = Console.ReadLine();
            Console.WriteLine("- Please enter your last name : ");
            string last_name1 = Console.ReadLine();
            string full_name1 = first_name1 + " " + last_name1;

            Console.WriteLine("How old are you ? ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your student number ? ");
            string st_number1 = Console.ReadLine();

            Console.WriteLine("Please enter your scores : (-,-,-,-,-)");
            string[] scores1 = Console.ReadLine().Split(',');
            double[] scoresfinal = new double[scores1.Length];
            for (int i = 0; i < scores1.Length; i++)
            {
                double.TryParse(scores1[i], out scoresfinal[i]);
            }
            



            Console.WriteLine("- Please enter your address number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("- Please enter your street : ");
            string street1 = Console.ReadLine();
            Console.WriteLine("- Please enter your city : ");
            string city1 = Console.ReadLine();
            Console.WriteLine("- Please enter your country : ");
            string country1 = Console.ReadLine();

            Adress full_addres1 = new Adress(number1, street1, city1, country1);

            Student person1 = new Student(first_name1, last_name1, full_addres1, st_number1, age1, scoresfinal);

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Here's the following datas about the student : ");
            Console.WriteLine("- Student " + full_name1 + " average score is " + person1.Average_score );
            Console.WriteLine("- Student " + full_name1 + " is living in " + city1);
            Console.WriteLine("- Student " + full_name1 + " address is " + full_addres1);
            Console.WriteLine();
            Console.WriteLine("- Student " + full_name1 + " is " + age1 + " years old");
            Console.WriteLine("- Person " + full_name1 + " have the following student number : " + st_number1);
            Console.ReadKey();
        }

        private static void DisplayMenu()
        {
            Console.Clear(); 
            Console.WriteLine("=========================");
            Console.WriteLine("1. Display message");
            Console.WriteLine("2. Display detailed information about student"); 
            Console.WriteLine("3. Exit");
            Console.WriteLine("=========================");
            Console.Write("Please enter your choice (1-3) ");
        }

    }
}

