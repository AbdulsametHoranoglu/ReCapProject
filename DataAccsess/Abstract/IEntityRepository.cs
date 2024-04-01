using Entities.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    public interface IEntityRepository<T> where T : class, ICar, new()
    {
        void GetById(T entity);
        List<T> GetAll(Expression <Func<T, bool>>  filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
