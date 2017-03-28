using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ferdis.Models
{
    public enum Size { HalfPint, Pint, Quart };

    public class ItemInventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ItemID { get; set; }        
        public Size Size { get; set; } 
        public int QtyOnHand { get; set; }
        public decimal Price { get; set; }        

        public Item Item { get; set; }
    }
}
