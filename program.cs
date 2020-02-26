using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("Hello, I'm a old volkswagen", "1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("Hi, my name is yugo", "1980 Yugo Koral", 700, 56000);
      Car ford = new Car("I'm ford", "1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("Hi, agian. I'm old AMC.", "1976 AMC Pacer", 400, 198000);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      Console.WriteLine("Enter maximus miles:");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);
      int cantAfford = 0;

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
        else {
          cantAfford ++;
        }
      }

      if (cantAfford == 4)
        {
          Console.WriteLine("Sorry, you dont have enough money :(");
        } 

      foreach(Car automobile in CarsMatchingSearch)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          Console.WriteLine(automobile.MakeModel);
          Console.WriteLine(automobile.Message);
        }
      }
    }
  }
}