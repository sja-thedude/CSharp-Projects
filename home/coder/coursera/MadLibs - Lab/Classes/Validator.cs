using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MadLibs
{
    public static class Validator
    {
        /// <summary>
        /// Validates the name entered by the user by:
        /// making sure it's between 3 to 20 characters in length
        /// making sure all characters are letters
        /// /// </summary>
        /// <param name="name">The name of the user</param>
        /// <returns></returns>
        public static bool ValidateName(string name)
        {
            //TODO [TASK2]
            //Make sure that the string's length is between 3 and 20.


            //Make sure the that the name string does not contain any numbers or other unwanted characters
            //Loop through the characters. If any of them is not a letter, return false;


            return true;
        }
        /// <summary>
        /// Ensures that the city name is between 3 to 15 characters
        /// Ensures that the city string parameters doesn't contain non-letter characters
        /// </summary>
        /// <param name="city"> the city name of the user</param>
        /// <returns>False if the city is invalid</returns>
        public static bool ValidateCity(string city)
        {
            //TODO [TASK2]
            //Make sure that the string's length is between 3 and 15

            //Make sure the that the city string does not contain any numbers or other unwanted characters

            //Loop through the characters. If any of them is not a letter, return false;
            return true;
        }
        /// <summary>
        /// Ensures that age is a number between 5 and 99
        /// </summary>
        /// <param name="age"></param>
        /// <returns>False if the age is invald</returns>
        public static bool ValidateAge(int age)
        {
            //TODO [TASK2]
            //implement a condition to reutrn false if the age is not between 5 and 99
            return true;
        }
        /// <summary>
        /// Ensures that the poem length is a value between 5 and 20
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static bool ValidatePoemLength(int length)
        {
            //TODO [TASK2]
            //implement a condition to reutrn false if the the poem length is not between 5 and 20
            return true;
        }
    }
}
