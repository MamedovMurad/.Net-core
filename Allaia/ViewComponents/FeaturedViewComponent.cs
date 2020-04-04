using Allaia.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allaia.ViewComponents
{
    public class FeaturedViewComponent: ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public FeaturedViewComponent(IMapper mapper,
                                       IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productRepository.GetFeaturedProducts(8);
            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(model);
        }
    }
}
