using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CarManager : ICarManager
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }



    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }
}
