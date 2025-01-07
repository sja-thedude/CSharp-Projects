using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalyst.Models;
using Microsoft.VisualBasic;

namespace MadLibs
{
    /// <summary>
    /// This class contains methods and fields related to the management the conversation flow in the app.
    /// </summary>
    public class Conversation
    {
        string QUESTIONS_PATH = "Resources/questions.txt";

        List<string> questions = new List<string>();


        Person Person = new Person();

        Poem Poem = new Poem();

        LanguageModel Model = new LanguageModel();

        Randomizer Randomizer = new Randomizer();

        public int Length { get; set; }



        /// <summary>
        /// A constructor method that calls other methods to initailize the conversation object
        /// </summary>
        /// <param name="length">The length of the conversation (number of questions to promot the user) </param>
        public Conversation(int length)
        {
            Length = length;
            LoadQuestions();

        }

        /// <summary>
        /// Loads the user questions from text file to a list
        /// </summary>
        void LoadQuestions()
        {

            Console.WriteLine("Loading questions...");
            //TODO [TASK1] read all the questions from QUESTIONS_PATH filepath
            //make sure to convert the results into lists of strings



            //TODO [TASK2]
            //implement exception handling to catch integer parsing error.
            Console.WriteLine($"{questions.Count} questions were loaded");
        }

        /// <summary>
        /// A method that calls other methods to promot the user for different kinds of inputs
        /// </summary>
        void GatherUserInfo()
        {
            Person.GetPersonName();
            Person.GetPersonAge();
            Person.GetPersonCity();
            Poem.GetPoemLength();

        }

        /// <summary>
        /// A method that extracts tokens from text based on the start and end locations indicated by the token object
        /// </summary>
        /// <param name="token">A token object that contains the start and end location of a token within the user's input </param>
        /// <param name="text">The user's input</param>
        /// <returns>returns a string that represents the extracted word </returns>
        string ExtractPOS(PToken token, string text)
        {
            //TODO [TASK5] extract a word based on the token's start and end points.
            //Use the Substring() Method

            return "";

        }

        /// <summary>
        /// Processes the user's input to extract nouns, verbs, adjectives and adds them to corresponding lists.
        /// </summary>
        /// <param name="text">User's input</param>
        void ProcessTextInput(string text)
        {
            var tokens = Model.ExtractTokens(text);

            foreach (var token in tokens)
            {

                var word = ExtractPOS(token, text);
                switch (token.tag)
                {
                    case "NOUN": Poem.NounsList.Add(word); break;
                    case "ADJ": Poem.AdjectivesList.Add(word); break;
                    case "VERB": Poem.VerbsList.Add(word); break;
                    default: break;

                }

            }


        }

        /// <summary>
        /// Engages theuser with a conversation by asking user an X number of questions
        /// The method gathers user input and calss the ProcessTextInput to have the text processed 
        /// </summary>
        void AskQuestions()
        {

            for (int i = 0; i < Length; i++)
            {
                var index = Randomizer.GenerateRandomNumber(questions.Count);
                Console.WriteLine(questions[index]);
                var input = Console.ReadLine();
                ProcessTextInput(input);
            }
        }

        /// <summary>
        /// Starts the converstion flow. This method calls the two other methods to gather user info and prompt the user for answers.
        /// </summary>
        public void Start()
        {
            GatherUserInfo();
            AskQuestions();

        }
        /// <summary>
        /// Prints the poem to the console.
        /// </summary>

        public void PrintPoem()
        {
            Console.WriteLine("I'm wriiing your poem now. Please wait...");
            string poem = Poem.GeneratePoem(Person);
            Console.WriteLine(poem);
            Save(poem);

        }


        /// <summary>
        /// Saves the poem to a text file
        /// </summary>
        public void Save(string poem)
        {
            Console.WriteLine("I'm saving your poem now. Please wait...");
            //TODO [TASK5]
            //Write the poem to the Poems directory. Use the poem title and the time ticks as a filename.
            //Implement exception handling to handle file errors
            File.WriteAllText($"Poems/{Poem.Title} {DateTime.Now.Ticks}.txt", poem);
            Console.WriteLine("Poem Saved!");

        }
    }
}