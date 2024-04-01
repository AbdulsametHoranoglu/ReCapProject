using Business.Concretes;
using DataAccsess.Abstract;
using DataAccsess.Concretes.EntityFramework;
using DataAccsess.Concretes.InMemory;

EfCarDal efCarDal = new EfCarDal();

CarManager carManager = new CarManager(efCarDal);

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}
