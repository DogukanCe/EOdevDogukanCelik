using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOrderService:IEntityService<Order>
    {
        bool ChangeStatus(int id,string name);
    }
}
