using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadLibs
{
    public class Person
    {
        public string Fullname { get; set; } = "";
        public int Age { get; set; }
        public string City { get; set; }

        public void GetPersonName()
        {
            Console.WriteLine("Hi, I am Emma!, What's your name?");
            //TODO [TASK2]
            //Read the user's name from console and assign it to the Fullname string property



            //TODO [TASK3]
            //Validate the user's name by calling the Validator.ValidateName() method
       
        }

        public void GetPersonAge()
        {
            Console.WriteLine("How old are you?");
            //TODO [TASK2]
            //rRead the user's age from console and assign it to the Age property
            //Hint: use the Int32.Parase() method

        

            //TODO [TASK3]
            //Validate the user's age by calling the Validator.ValidateAge() method
            //implement exception handling to catch runtime errors related to string conversion


           

        }

        public void GetPersonCity()
        {
            Console.WriteLine("Where do you live?");

            //TODO [TASK2]
            //rRead the user's City from console and assign it to the City string property



            //TODO [TASK3]
            //Validate the user's city by calling the Validator.ValidateCity() method

          
        }

    }
}