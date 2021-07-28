using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            this._customerDal = customerDal;
        }
        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
           
            return _customerDal.GetAll(p => p.CustomerName == filter)
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllById(int id)
        {
            return _customerDal.GetAll(p => p.CustomerId == id);
        }

        public List<Customer> GetAlll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetByUnitPrice(decimal min, decimal max)
        {
            return _customerDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public bool Validate(int id)
        {
            throw new NotImplementedException();
        }
    }
}
