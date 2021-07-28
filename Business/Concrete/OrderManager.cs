using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            this._orderDal = orderDal;
        }
        public bool ChangeStatus(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.GetAll(p=>p.Status==filter);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllById(int id)
        {
            return _orderDal.GetAll(p => p.CustomerId == id);
        }

        public List<Order> GetAlll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetByUnitPrice(decimal min, decimal max)
        {
            return _orderDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
