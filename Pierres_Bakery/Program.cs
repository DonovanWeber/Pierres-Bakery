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
        Console.WriteLine("At Pierre's Bakery we sell bread and pastries ['B' to order bread 'P' to order pastries]");
        string orderAnswer = Console.ReadLine();
        if( orderAnswer == "B" || orderAnswer == "b")
        {
          Bread();
        }
        else if (orderAnswer == "P" || orderAnswer == "p")
        {
          Pastry();
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
      string stringAnswer = Console.ReadLine();
      int answer = int.Parse(stringAnswer);
      Bread userOrder = new Bread(answer);
      if(answer > 1)
      {
      Console.WriteLine("_____________________");
      Console.WriteLine(answer + " loaves of bread will cost $" + userOrder.CalculatePriceOfBread());
      }
      else
      { 
        Console.WriteLine("_____________________");
        Console.WriteLine(answer + " loaf of bread will cost $" + userOrder.CalculatePriceOfBread());
      }
      Console.WriteLine("Would you like to order a pastry or leave the bakery ['Y' to order a pastry 'Enter' to go leave]");
      string secondAnswer = Console.ReadLine();
      if (secondAnswer == "Y" || secondAnswer == "y")
      {
        Pastry();
      }
      else
      {
        Main();
      }
    }
    static void Pastry()
    {
      Console.WriteLine("How many pastries would you like to order?");
      string stringAnswer = Console.ReadLine();
      int answer = int.Parse(stringAnswer);
      Pastry userOrder = new Pastry(answer);
      if (answer > 1)
      {
        Console.WriteLine("_____________________");
        Console.WriteLine(answer + " pastries will cost $" + userOrder.CalculatePriceOfPastry());
      }
      else
      {
        Console.WriteLine("_____________________");
        Console.WriteLine(answer + " pastry will cost $" + userOrder.CalculatePriceOfPastry());
      }
      Console.WriteLine("Would you like to order bread");
      string secondAnswer = Console.ReadLine();
      if (secondAnswer == "Y" || secondAnswer == "y")
      {
        Bread();
      }
      else
      {
        Main();
      }
    }
  }
}