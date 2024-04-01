using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IBrandManager
{
    List<Car> GetAll();
    List<Car> GetCarsBylBrandId(int id);
    List<Car> GetCarsBylColorId(int id);

    List<Car> Add(Car car);
}
