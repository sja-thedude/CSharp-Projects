using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Catalyst.Models;
using Microsoft.VisualBasic;

namespace TweetGen
{
    /// <summary>
    /// This class contains methods and fields related to the management the conversation flow in the app.
    /// </summary>
    public class Conversation
    {

        List<string> questions = new List<string>();



        Product Product = new Product();

        Tweet Tweet = new Tweet();

        LanguageModel Model = new LanguageModel();


   

        /// <summary>
        /// A method that calls other methods to promot the user for various info
        /// </summary>
        void GatherTweetInfo()
        {
            Product.GetProductName();
            Product.GetProductDescription();
            Tweet.GetTweetCount();
            ProcessTextInput(Product.Description);

        }

        /// <summary>
        /// A method that extracts tokens from text based on the start and end locations indicated by the token object
        /// </summary>
        /// <param name="token">A token object that contains the start and end location of a token within the user's input </param>
        /// <param name="text">The user's input</param>
        /// <returns>returns a string that represents the extracted word </returns>
        string ExtractPOS(PToken token, string text)
        {
            return text.Substring(token.start, token.end + 1 - token.start);

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
                    case "NOUN": Tweet.NounsList.Add(word); break;
                    case "ADJ": Tweet.AdjectivesList.Add(word); break;
                    case "VERB": Tweet.VerbsList.Add(word); break;
                    default: break;
                }
            }
        }

       

        /// <summary>
        /// Starts the converstion flow. This method calls the two other methods to gather user info and prompt the user for answers.
        /// </summary>
        public void Start()
        {
            GatherTweetInfo();

        }
        /// <summary>
        /// Prints the generated tweets to the console.
        /// </summary>

        public void PrintTweets()
        {
            Console.WriteLine("I'm generating your tweets now. Please wait...");

            string tweets = Tweet.GenerateTweets(Product.Name);
            
            Console.WriteLine("Here are your tweets: ");
            Console.WriteLine("----------------------");
            Console.WriteLine(tweets);
            Console.WriteLine("----------------------");

            Save(tweets);

        }


        /// <summary>
        /// Saves the tweet list to a text file
        /// </summary>
        public void Save(string Tweets)
        {
            Console.WriteLine("I'm saving your tweets now. Please wait...");
            File.WriteAllText($"Tweets/{Product.Name} {DateTime.Now.Ticks} .txt",Tweets);
            Console.WriteLine("Tweets saved to file!");

        }
    }
}