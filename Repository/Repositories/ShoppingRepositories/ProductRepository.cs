using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
  public  class ProductRepository:IProductRepository
    {
        private readonly AllaiaDbContext _context;
        public ProductRepository(AllaiaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetTopSellingProducts(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Include("Label")
                                    .Include("Discounts")
                                    .Include("Discounts.Discount")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsTopSelling)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }
        public IEnumerable<Product> GetFeaturedProducts(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Include("Label")
                                    .Include("Discounts")
                                    .Include("Discounts.Discount")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsFeatured)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }
    }
}
