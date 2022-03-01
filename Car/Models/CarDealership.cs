using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public int Year { get; set; }
    public string MakeModel { get; set; }
    public int Miles { get; set; }
    public int Price { get; set; }
    private static List<Car> _dealership = new List<Car> {};

    public Car(int year, string makeModel, int miles, int price)
    {
      Year = year;
      MakeModel = makeModel;
      Miles = miles;
      Price = price;
      _dealership.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _dealership;
    }
  }
}