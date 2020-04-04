﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetTopSellingProducts(int limit);
        IEnumerable<Product> GetFeaturedProducts(int limit);
    }
}
