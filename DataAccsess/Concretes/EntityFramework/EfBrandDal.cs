﻿using DataAccsess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concretes.EntityFramework;

public class EfBrandDal : IBrandDal
{
    public void Add(Brand entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Brand entity)
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void GetById(Brand entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Brand entity)
    {
        throw new NotImplementedException();
    }
}
