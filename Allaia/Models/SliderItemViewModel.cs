using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allaia.Models
{
    public class SliderItemViewModel
    {
        public SliderPositon SliderPositon { get; set; }
        public int OrderBy { get; set; }
        
        public string Title { get; set; }
      
        public string Slogan { get; set; }
      
        public string Image { get; set; }
    
        public string ActionText { get; set; }
      
        public string EndPoint { get; set; }
    }
}
