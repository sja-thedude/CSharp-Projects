using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MadLibs
{
    public class Poem
    {

        const string POEMS_PATH = "Resources/poems.txt";
        const string TITLES_PATH = "Resources/titles.txt";
        List<string> LinesList = new List<string>();
        List<string> TitlesList = new List<string>();
        public string Title, Body, Footer = "";
        public int Length { get; set; }



        public List<string> NounsList = new();
        public List<string> VerbsList = new();
        public List<string> AdjectivesList = new();

        Randomizer random = new Randomizer();
        /// <summary>
        /// A constrcutor method that loads the needed strings for poem titles and poem lines.
        /// </summary>
        public Poem()
        {
            LoadTitles();
            LoadPoemLines();
        }

        /// <summary>
        /// A method that reads the poem line templates into a list
        /// </summary>
        void LoadPoemLines()
        {
            //TODO [TASK1]
            // Load all poem lines from the POEMS_PATH filepath to the LinesList object
            //make sure to convert the results into lists of strings



            //TODO [TASK4]
            //Write a console message that tells the user how many poem line templates were loaded. Use the + operand
         

        }

        /// <summary>
        /// A method that loads the poem titels into a list
        /// </summary>
        void LoadTitles()
        {
            //TODO [TASK1]
            //Load all titles from the TITLES_PATH filepath to the TitlesList object
            //make sure to convert the results into lists of strings


            TitlesList = File.ReadAllLines(TITLES_PATH).ToList();

            //TODo [TASK2] implement exception handling to catch file error
            // TitlesList = File.ReadAllLines(TITLES_PATH).ToList();

            //TODO [TASK4]
            //Write a console message that tells the user how many titles were loaded.v Use C# string interpolation.
        }

        /// <summary>
        /// A method that prompts the user about the needed poem length (number of lines for the generated poem)
        /// </summary>
        public void GetPoemLength()
        {
            Console.WriteLine("How long do you want your poem to be?");

            //TODO [TASK2] 
            //read the poem length from Console 
            //implement exception handling to catch integer parsing error.
            Length = int.Parse(Console.ReadLine());

            //TODO [TASK2]
            //Validate the poem length which must be a value between 5 and 30
            if (!Validator.ValidatePoemLength(Length))
            {
                Console.WriteLine("Enter a valid length between 5 and 30"); ;
                GetPoemLength();
            }

        }


        /// <summary>
        /// A method that generates the title for the generated poem. the method takes the name of the user as an argument 
        /// and generates a poem titles based on it.
        /// Poem titles looks something like this: "Symphony of the Dusk by Alice"
        /// </summary>
        /// <param name="name">The name of the user which is used to generate the poem title</param>
        void GenerateTitle(string name)
        {

            var titleTemplate = TitlesList[random.GenerateRandomNumber(TitlesList.Count)];
            //processes the title template to replace nouns and verbs
            Title = ProcessLine(titleTemplate);
            //TODO [TASK4] concatenate the title with the user name to create a poem header. Use C# string interpolation
            Title = $"{Title} by {name}";

        }



        /// <summary>
        /// This method process the poem line/title to replace nouns, verbs, and adjectives
        /// which ones previously extracted from user input
        /// </summary>
        /// <param name="line">Input String with placeholder text such as [NOUN], [VERB], [ADJ] </param>
        /// <returns></returns>
        string ProcessLine(string line)
        {


            return "";
            //TODO [TASK 5]
            //remove the return line; statement above
            //create a StingBuilder object that takes the line object as initial string.

            

            //code to retieve words from user input. DON"T TOUCH
            var noun = NounsList[random.GenerateRandomNumber(NounsList.Count)];
            var verb = VerbsList[random.GenerateRandomNumber(VerbsList.Count)];
            var adjec = AdjectivesList[random.GenerateRandomNumber(AdjectivesList.Count)];


            //TODO [TASK5]
            //Use the Replace method tp replace the palceholder for [VERB] [ADJ] [NOUN] with the noun, verb, adjec strings
           

            //return a string object from the StringBuilder object using the ToString() method.




        }

        /// <summary>
        /// This method generates the poem body (the poem itself)
        /// by randomly selecting a poem line from the loaded lines.
        /// Then the method replaces the placeholders from the loaded lines with
        /// corresponding words from the user input.
        /// </summary>
        void GenerateBody()
        {
            //TODO [TASK4]
            //Create a StringBuilder object 
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.Length; i++)
            {
                var index = random.GenerateRandomNumber(LinesList.Count);
                var line = LinesList[index];
                line = ProcessLine(line); //fixed
                //TODO [TASK4]
                //Append the line string to the StringBuilder object
                builder.AppendLine(line);

            }
            //[TODO] [TASK4]
            //retrieve the final string from the StringBuilder object and assign it to the Body string property
            Body = builder.ToString();


        }

        /// <summary>
        /// This method takes the person object as an argument to generate a footer note of the poem based on the person's name .
        /// Example: "This poem was generated by Alice on 2/2/2024
        /// </summary>
        /// <param name="person">The person object which represents the user using the app</param>
        /// <returns></returns>
        public void GenerateFooter(Person person)
        {

            var footerTemplate = "This poem was written by [NAME] on [DATE]";


            //TODO [TASK5]
            //Use string replacement to create a footer message by replacing [NAME] wuth the person's name and [DATE] with today's date
            //make sure to assign the result string to the Footer string object
          





        }
        /// <summary>
        /// This method formats the poem in a readable format by adding some text delimiters 
        /// to make the text more readable
        /// </summary>
        /// <returns></returns>
        string FormatPoem()
        {
            var delimiter = "-------------------------------";
            //TODO [TASK5] - Formatting
            // Create a new StringBuilder object with the delimiter string as an initial text
            //Format the poem using the following sequence: Title > delimiter -> body -> delimiter -> footer 
            //reutn the string from the StringBuilder object
            return "";

          
        }

        /// <summary>
        /// This method calls other methods that generate different parts of the poem then combines the results into wonce string.
        /// </summary>
        /// <param name="person">A person object representing the user of the app </param>
        /// <returns></returns>
        public string GeneratePoem(Person person)
        {

            GenerateTitle(person.Fullname);
            GenerateBody();
            GenerateFooter(person);
            return FormatPoem();

        }




    }
}