using Business.Concrete;
using DataAccess.Concrete.EntityFreamework;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var order in orderManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(order.Status);
            }
        }
    }
}
