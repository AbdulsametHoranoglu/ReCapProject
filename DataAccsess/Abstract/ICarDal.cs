﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract;

public interface ICarDal
{
    void GetById(int id);
    List<Car> GetAll();
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);

}
