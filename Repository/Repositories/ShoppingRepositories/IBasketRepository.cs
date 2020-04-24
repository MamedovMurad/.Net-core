
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    
  public  interface IBasketRepository
    {
        IEnumerable<Basket> GetBasketByToken(string token);
        Basket CreatedBasket(Basket basket);
    }


    public class BasketRepository:IBasketRepository
    {
        private readonly AllaiaDbContext _context;
        public BasketRepository(AllaiaDbContext context)
        {
            _context = context;
        }

        public Basket CreatedBasket(Basket basket)
        {
            basket.AddedDate = DateTime.Now;
            basket.ModifiedDate = DateTime.Now;
            _context.Baskets.Add(basket);
            _context.SaveChanges();
            return basket;
        }

        public IEnumerable<Basket> GetBasketByToken(string token)

        {
            var b = _context.Baskets;
            return b
                .Include("Product")
                .Include("Product.Discounts")
                .Include("Product.Discounts.Discount")
                .Include("Product.Photos")
                .Where(b => b.Token == token)
                .ToList();
        }
    }
}
