using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ferdis.Models
{
    public class Item
    {
        public int ID { get; set; }
        public ItemType ItemType { get; set; }    
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QtyAvailable { get; set; }
        public string ImageURL { get; set; }
    }
}
