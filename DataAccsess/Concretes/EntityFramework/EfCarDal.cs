using DataAccsess.Abstract;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concretes.EntityFramework;

public class EfCarDal : ICarDal
{
    public void Add(Car entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var AddedEntity = context.Entry(entity);
            AddedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(Car entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var DeletedEntity = context.Entry(entity);
            DeletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return filter == null
                ? context.Set<Car>().ToList()
                : context.Set<Car>().Where(filter).ToList();
        }
    }

    public List<Car> GetAll()
    {
        throw new NotImplementedException();
    }

    public void GetById(Car entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Car entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var UpdatededEntity = context.Entry(entity);
            UpdatededEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
