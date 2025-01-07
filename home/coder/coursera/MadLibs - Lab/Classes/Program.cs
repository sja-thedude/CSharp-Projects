// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;
using System.Data;
using Catalyst;
using Mosaik.Core;

namespace MadLibs
{
  public class Program
  {
    public static void Main(string[] args)
    {

     
      Conversation conv = new Conversation(5);
      conv.Start();
      conv.PrintPoem();
      
    }
  }


}
















