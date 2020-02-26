using System;

namespace Dealership.Models
{
  public class Car
  {
    public string Message;
    public string MakeModel;
    public int Price;
    public int Miles;

    public Car(string message, string makeModel, int price, int miles)
    {
      Message = message;
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (Price < maxPrice & Miles < maxMiles);
    }
  }
}