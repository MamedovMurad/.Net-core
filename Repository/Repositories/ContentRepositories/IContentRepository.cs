using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
 public interface IContentRepository
    {
        IEnumerable<SliderItem> GetShopCollections();
        IEnumerable<ShopColllection> GetShopColllections();
    }
}
