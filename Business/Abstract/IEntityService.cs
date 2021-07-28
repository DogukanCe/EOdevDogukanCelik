using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
  public  interface IEntityService<T>where T:class,IEntity , new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        List<T> GetAlll();
        List<T> GetAllById(int id);

        List<T> GetByUnitPrice(decimal min, decimal max);
    }
}
