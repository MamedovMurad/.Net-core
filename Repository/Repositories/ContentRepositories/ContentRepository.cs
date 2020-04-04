using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly AllaiaDbContext _context;
        public ContentRepository(AllaiaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ShopColllection> GetShopColllections()
        {
            return _context.ShopColllections.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public IEnumerable<SliderItem> GetShopCollections()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.OrderByDescending(b => b.AddedDate).ToList();
        }
    }
}
