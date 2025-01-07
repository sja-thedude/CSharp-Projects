using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TweetGen
{
    public class Tweet
    {

        const string TWEETS_PATH = "Resources/tweets.txt";
        const string TAGS_PATH = "Resources/tags.txt";
        List<string> TweetsList = new List<string>();
        List<string> TagsList = new List<string>();
        public string Tag, Footer = "";
        public int TweetsCount { get; set; }

        public List<string> NounsList = new();
        public List<string> VerbsList = new();
        public List<string> AdjectivesList = new();

        Randomizer random = new Randomizer();
        /// <summary>
        /// A constrcutor method that loads the needed strings for poem titles and poem lines.
        /// </summary>
        public Tweet()
        {
            LoadTags();
            LoadTweets();
        }

        /// <summary>
        /// A method that reads the tweet templates into a list
        /// </summary>
        void LoadTweets()
        {

            TweetsList = File.ReadAllLines(TWEETS_PATH).ToList();
            Console.WriteLine($"{TweetsList.Count} tweets were loaded");
        }

        /// <summary>
        /// A method that loads the tweet tags into a list
        /// </summary>
        void LoadTags()
        {
            
            TagsList = File.ReadAllLines(TAGS_PATH).ToList();
            Console.WriteLine($"{TagsList.Count} tags were loaded");
        }

        /// <summary>
        /// A method that prompts the user about the needed tweet coumt
        /// </summary>
        public void GetTweetCount()
        {
            Console.WriteLine("How many tweets do you want me to generate?");

            //TODO: prompt user for the number of tweets they want to generate
            //Store the results in the TweetsCount property
            //make sure to implement input validation and exception handling

        }

        /// <summary>
        /// A method that generates the tweet tags
        /// </summary>
        string GenerateTags()
        {

            var tag1 = TagsList[random.GenerateRandomNumber(TagsList.Count)];
            var tag2 = TagsList[random.GenerateRandomNumber(TagsList.Count)];
            var tag3 = TagsList[random.GenerateRandomNumber(TagsList.Count)];

            //TODO: remove the spaces from the strings above: tag1, tag2, tag3
            //Append a # sign before each one of these strings
            //combine these strings and assign the result to the Tag property
           
            
            return Tag;
        }

        /// <summary>
        /// This method process the tweet to replace nouns, verbs, and adjectives 
        /// </summary>
        /// <param name="tweet">Input String with placeholder text such as [NOUN], [VERB], [ADJ] </param>
        /// <returns></returns>
        string ProcessTweet(string Tweet, string ProductName)
        {
            var builder = new StringBuilder();

            var noun = NounsList[random.GenerateRandomNumber(NounsList.Count)];
            var verb = VerbsList[random.GenerateRandomNumber(VerbsList.Count)];
            var adjec = AdjectivesList[random.GenerateRandomNumber(AdjectivesList.Count)];
            builder.AppendLine(Tweet);


            //TODO: Replace the placeholders: [VERB], [NOUN], [ADJ] with the generated onces: noun, verb, adjec
            //replace the [PNAME] placeholder with the ProductName string
            //return the final string from the StringBuilder object
          

            return "";


        }

        /// <summary>
        /// This method generates a set of tweets
        /// </summary>
        public string GenerateTweets(string ProductName)
        {

            //TODO: Create a new StringBuilder object
            for (int i = 0; i < this.TweetsCount; i++)
            {
                var index = random.GenerateRandomNumber(TweetsList.Count);
                var tweet = TweetsList[index];
                tweet += GenerateTags();
                var processedTweet = ProcessTweet(tweet,ProductName);

                //TODO: append the proccessedTweet string to the string builder object
            }
            //return final string from the string builder

          return "";
         
        }


    }
}