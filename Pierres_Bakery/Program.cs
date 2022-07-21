using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Menu();


    }
    static void Menu()
    {
      Console.WriteLine("Would you like to see the menu? ['Y' for yes 'Enter' to leave the bakery]");
      string answer = Console.ReadLine();
      if (answer == "Y" || answer == "y")
      {
        Console.WriteLine("At Pierre's Bakery we sell bread and pastries. Each Pastry costs 2$ and your third one is half off. Each loaf of bread cost 5$ and you get every third loaf FREE! ['Y' to order 'Enter' to go back]");
        string orderAnswer = Console.ReadLine();
        if( orderAnswer == "Y" || orderAnswer == "y")
        {
          Bread();
        }
        else 
        {
          Main();
        }
      }

    }
    static void Bread()
    {
      Console.WriteLine("How many loaves of bread would you like to order?");
      string stringAnswer1 = Console.ReadLine();
      int breadAnswer = int.Parse(stringAnswer1);
      Bread userOrder1 = new Bread(breadAnswer);
      Console.WriteLine("How many pastries would you like to order?");
      string stringAnswer2 = Console.ReadLine();
      int pastryAnswer = int.Parse(stringAnswer2);
      Pastry userOrder2 = new Pastry(pastryAnswer);
      if(breadAnswer >= 1 && pastryAnswer >= 1)
      {
        Console.WriteLine("_____________________");
        Console.WriteLine("You ordered " + breadAnswer + " loaf/loaves of bread and " + pastryAnswer + " pastry/pastries Your total cost will be: $" + (userOrder1.CalculatePriceOfBread() + userOrder2.CalculatePriceOfPastry()));
      }
      else if (breadAnswer <= 0 && pastryAnswer <= 0 )
      {
        Console.WriteLine("You might have pressed a wrong button or entered a non-usable number");
        Console.WriteLine("Please order at least one loaf of bread or pastry to get your total cost.");
        Console.WriteLine("['Y' to go back to the menu or 'Enter' to go back to the the start]");
         string answer = Console.ReadLine();
        if (answer == "Y" || answer == "y")
        {
          Bread();
        }
        else 
        {
          Main();
        }
      }
      else if(pastryAnswer == 0)
      {
        Console.WriteLine("You ordered " + breadAnswer + " loaf/loaves of bread Your total cost will be: $" + userOrder1.CalculatePriceOfBread());
      }
      else if(breadAnswer == 0)
      {
         Console.WriteLine("You ordered " + pastryAnswer + " pastry/pastries Your total cost will be: $" + userOrder2.CalculatePriceOfPastry());
      }
      else 
      {
        Main();
      }
    }
  }
}