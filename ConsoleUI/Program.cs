using Business.Concretes;
using DataAccsess.Concretes.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}
