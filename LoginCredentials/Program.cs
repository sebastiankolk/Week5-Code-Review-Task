﻿using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
            string Login;
            string Password;
            Console.WriteLine("Login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password: ");
            Password = Console.ReadLine();

            if ((Login == "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("Welcome.");
            }
            else if ((Login == "admin") && (Password != "pass1234"))
            {
                Console.WriteLine("The password is incorrect");
            }
            else if ((Login != "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("The user name is incorrect.");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}
