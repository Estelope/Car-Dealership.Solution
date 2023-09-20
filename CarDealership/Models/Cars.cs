using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Id {get; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string description)
    {
     // Title = title;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

      public static Car Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
  }
}