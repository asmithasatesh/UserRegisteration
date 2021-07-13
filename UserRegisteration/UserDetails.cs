﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    class UserDetails
    {
        public static string firstname;
        public static string lastname;
        public static string emails;
        public static string phoneNumber;
        public static string Password;



        public static void GetUserInformation()
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
            Regex email = new Regex(@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex phone = new Regex(@"^[0-9]+\s[0-9]{10}$");
            //Regex passWord = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            Regex passWord = new Regex(@"^(?=.*[A-Z]).{8,}$");


            //Get First Name from user
            Console.WriteLine("\nEnter First Name starting with Caps(minimum 3 characters)");
            while (true)
            {
                firstname = Console.ReadLine();
                if (regex.IsMatch(firstname))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid First Name!");
                }
            }

            //Get Last Name from user
            Console.WriteLine("\nEnter Last Name starting with Caps(minimum 3 characters)");
            while (true)
            {
                lastname = Console.ReadLine();
                if (regex.IsMatch(lastname))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid Last Name!");
                }
            }
            //Get Last Name from user
            Console.WriteLine("\nEnter Email Address");
            while (true)
            {
                emails = Console.ReadLine();
                if (email.IsMatch(emails))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid Email!");
                }
            }
            //Get Phone Number from user
            Console.WriteLine("\nEnter Phone Number in the form (COUNTRY CODE \"Space\" 10-digit PHONE NUMBER)");
            while (true)
            {
                phoneNumber = Console.ReadLine();
                if (phone.IsMatch(phoneNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid Email!");
                }
            }
            //Get PassWord from user
            Console.WriteLine("\nEnter Password (minimum 8 characters)");
            while (true)
            {
                 Password= Console.ReadLine();
                if (passWord.IsMatch(Password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid Password (minimum 8 characters)!");
                }
            }


            Display();
        }

        public static void Display()
        {
            Console.WriteLine("\n***********Display User Details**********\n");
            Console.WriteLine("Your First name is: {0}", firstname);
            Console.WriteLine("Your Last name is: {0}", lastname);
            Console.WriteLine("Your Email is: {0}", emails);
            Console.WriteLine("Your Phone number is: {0}", phoneNumber);
            Console.WriteLine("Your password is: {0}", Password);

        }
    }
}
