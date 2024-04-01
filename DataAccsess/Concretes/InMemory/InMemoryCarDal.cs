using DataAccsess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concretes.InMemory;

public class InMemoryCarDal : ICarDal
{
    List<Car> _cars;

    public InMemoryCarDal()
    {
        List<Car> list = new List<Car> 
        { 
           new Car { Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 1500, Description = "BMW", ModelYear = DateTime.Today},
           new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 500, Description = "TOGG", ModelYear = DateTime.Today},
           new Car { Id = 3, BrandId = 2, ColorId = 4, DailyPrice = 500, Description = "TOGG", ModelYear = DateTime.Today},
           new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 500, Description = "TOGG", ModelYear = DateTime.Today},
           new Car { Id = 5, BrandId = 1, ColorId = 4, DailyPrice = 1500, Description = "BMW", ModelYear = DateTime.Today}

        };
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
        Car ToCarDelete = _cars.SingleOrDefault(Car => Car.Id == car.Id);
        _cars.Remove(ToCarDelete);
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void GetById(int id)
    {
        _cars[id].Id = id;

    }

    public void GetById(Car entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Car car)
    {
        Car ToCarUpdate = _cars.SingleOrDefault(Car => Car.Id == car.Id);
        _cars.Remove(ToCarUpdate);
    }
}
