using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  
  public class Bread
  {
    private static int _Price = 5;
    public int AmountOfBread { get; set; }
    public int Price { get; set; }
    public Bread(int bread)
    {
      AmountOfBread = bread;
    }
    public int CalculatePriceOfBread()
    {
      int totalPrice = 0;
      if (AmountOfBread == 0)
      {
        totalPrice += 0;
      }
      else if (AmountOfBread % 3 == 0)
      {
        for(int i = 0; i < AmountOfBread; i += 3)
        {
          int Discount = 10;
          int finalDiscount = (AmountOfBread / 3 )* Discount;
          totalPrice += finalDiscount;
        }
      }
      else if (AmountOfBread > 3)
      {
        int discount = 10;
        int amountOfBreadAfterDiscount = AmountOfBread % 3; 
        int discountedBread = AmountOfBread - amountOfBreadAfterDiscount;
        int priceOfExtraBread = amountOfBreadAfterDiscount * _Price;
        for (int i = 0; i <= amountOfBreadAfterDiscount; i += 3)
        {
          totalPrice += discountedBread / 3 * discount;
        }
        totalPrice += priceOfExtraBread;
      }
      else 
      {
          for(int i = 0; i < AmountOfBread; i++)
          {
            totalPrice += _Price;
          }
      }
      
      return totalPrice;
    }

  }
  
  public class Pastry 
  {
    public int AmountOfPastry{ get; set; }

    public Pastry(int amountOfPastry)
    {
      AmountOfPastry = amountOfPastry;
    }
  }
}