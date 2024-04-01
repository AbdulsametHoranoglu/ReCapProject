using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandManager
{
    IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public List<Car> Add(Car car)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Car> GetCarsBylBrandId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetCarsBylColorId(int id)
    {
        throw new NotImplementedException();
    }
}
