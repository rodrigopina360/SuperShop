﻿using SuperShop.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
    }
}
