using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ferdis.Models
{
    // Nutella Ice cream, Chocolate Pudding, Etc.
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ItemTypeID { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }     
        public string ImageURL { get; set; }

        public ItemType ItemType { get; set; }
        public ICollection<ItemInventory> ItemInventory { get; set; }
    }
}
