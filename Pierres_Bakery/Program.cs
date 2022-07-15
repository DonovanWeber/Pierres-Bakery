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
        Console.WriteLine("At Pierre's Bakery we sell bread and pastries ['B' to order bread 'P' to order pastries 'Y' to order both");
        string orderAnswer = Console.ReadLine();
        if( orderAnswer == "B" || orderAnswer == "b")
        {
          Bread();
        }
        else if (orderAnswer == "P" || orderAnswer == "p")
        {
          Pastry();
        }
        else if (orderAnswer == "Y" || orderAnswer == "y")
        {
          Bread();
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
      Console.WriteLine("How many loaves of bread would you like to order?")
      string stringAnswer = Console.ReadLine();
    }
    static void Pastry()
    {

    }
  }
}