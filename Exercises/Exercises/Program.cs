/* Excercises from the csharp tutorial for beginners course */

using System;


namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidInput();
            BiggerNumber();
            LandscapeOrPortrait();
            SpeedMonitor();
        }

        /**
         * validInput - takes in a number from user
         *              and prints if its valid or not
         */
        public static void ValidInput()
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 10)
                Console.WriteLine("Valid\n");
            else
                Console.WriteLine("Invalid\n");
        }

        /**
         * BiggerNumber - takes in two ints from stdin
         *                and prints which one is larger
         */
        public static void BiggerNumber()
        {
            Console.WriteLine("Enter number one:\n");
            int numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number two:\n");
            int numTwo = int.Parse(Console.ReadLine());

            if (numOne > numTwo)
                Console.WriteLine("numOne is greater than numTwo\n");
            else if (numOne < numTwo)
                Console.WriteLine("numTwo is greater than numOne\n");
            else
                Console.WriteLine("numOne is equal to numTwo\n");
        }
        /**
         * LandscapeOrPortrait - asks the user to enter the width
         *                    and height of a painting. Tells if
         *                    its a landscape or portrait.
         */
        public static void LandscapeOrPortrait()
        {

            Console.WriteLine("Enter width:\n");
            int width = int.Parse((Console.ReadLine()));

            Console.WriteLine("Enter height:\n");
            int height = int.Parse((Console.ReadLine()));

            if (width > height)
                Console.WriteLine("This is a landscape\n");
            else if (width < height)
                Console.WriteLine("this is a portrait\n");
            else
                Console.WriteLine("Dis a square\n");
        }

        public static void SpeedMonitor()
        {
            Console.WriteLine("Enter speed limit:\n");
            int speedLimit = int.Parse((Console.ReadLine()));

            Console.WriteLine("Enter speed of car:\n");
            int speedOfCar = int.Parse((Console.ReadLine()));

            if (speedOfCar <= speedLimit)
                Console.WriteLine("OK\n");
            else if (speedOfCar > speedLimit)
            {
                CalculateDemeritPoints(speedOfCar, speedLimit);
            }
        }

        public static void CalculateDemeritPoints(int carSpeed, int speedLimit)
        {
            if (carSpeed - speedLimit >= 65)
                Console.WriteLine("License Suspended.\n");
        }
    }
}
