using Allaia.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Allaia.ViewComponents
{
    public class BannerViewComponent:ViewComponent
    {
         private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public BannerViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;

        }
        public IViewComponentResult Invoke()
        {
            var collections = _contentRepository.GetShopColllections();

            var model = _mapper.Map<IEnumerable<ShopColllection>, IEnumerable<ShopCollectionViewModel>>(collections);

            return View(model);

        }
    }
    }

