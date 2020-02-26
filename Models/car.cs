using System;

namespace Dealership.Models
{
  public class Car
  {
    private string _message;
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string message, string makeModel, int price, int miles)
    {
      _message = message;
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
  
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public string GetMessage()
    {
      return _message;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_price < maxPrice & _miles < maxMiles);
    }
  }
}