using DataAccess.Abstract;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFreamework
{
    public class EfOrderDal : IOrderDal
    {
        public void Add(Order entity)
        {
            using (EOdevDogukanCelikDb context = new EOdevDogukanCelikDb())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Order entity)
        {
            using (EOdevDogukanCelikDb context = new EOdevDogukanCelikDb())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            using (EOdevDogukanCelikDb context = new EOdevDogukanCelikDb())
            {
                return context.Set<Order>().SingleOrDefault(filter);
            }
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            using (EOdevDogukanCelikDb context = new EOdevDogukanCelikDb())
            {
                return filter == null ? context.Set<Order>().ToList() : context.Set<Order>().Where(filter).ToList();
            }
        }

        public void Update(Order entity)
        {
            using (EOdevDogukanCelikDb context = new EOdevDogukanCelikDb())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
