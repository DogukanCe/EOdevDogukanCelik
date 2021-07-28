﻿using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService:IEntityService<Customer>
    {
        bool Validate(int id);
    }
}
