// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;
using System.Data;
using Catalyst;
using Mosaik.Core;

namespace TweetGen
{
  public class Program
  {
    public static void Main(string[] args)
    {

     
      Conversation conv = new Conversation();
      conv.Start();
      conv.PrintTweets();
      
    }
  }


}
















