using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Repositories.ShoppingRepositories;
using AutoMapper;
using Repository.Models;
using Allaia.Models;

namespace Allaia.ViewComponents
{
    public class HeaderBasketViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        public HeaderBasketViewComponent(IMapper mapper,
            IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;

        }
        public IViewComponentResult Invoke()
        {
            Request.Cookies.TryGetValue("token", out string token);

            var basketItems = _basketRepository.GetBasketByToken(token);

            var model = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);

            return View(model);

        }
    }
}

