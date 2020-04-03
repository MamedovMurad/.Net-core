using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allaia.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public byte StarCount { get; set; }
        public IList<string> Photos { get; set; }
        public LabelViewModel Label { get; set; }
        public DisCountViewModel Discount { get; set; }
    }
}
