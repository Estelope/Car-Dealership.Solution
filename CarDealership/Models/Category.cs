using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Car> Cars { get; set; }

      public Category(string categoryName)
    {
      Name = categoryName;
      _instances.Add(this);
      Id = _instances.Count;
      Cars = new List<Car>{};
    }

      public static void ClearAll()
    {
      _instances.Clear();
    }

      public static List<Category> GetAll()
    {
      return _instances;
    }

        public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
  }
}