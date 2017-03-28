using System;
using System.Collections.Generic;
using System.Linq;
using ferdis.Models;

namespace ferdis.DAL
{
    public static class DBInitializer
    {
        public static void Initialize(FerdiDBContext context)
        {
            context.Database.EnsureCreated();
            if (context.Items.Any())
            {
                return;
            }

            ItemType iceCream = new ItemType() { Name = "Ice Cream", ImageURL = "IceCreamGeneric.png" };
            ItemType pudding = new ItemType() { Name = "Pudding", ImageURL = "PuddingGeneric.png" };

            var itemTypes = new ItemType[] { iceCream, pudding };

            foreach (var itemType in itemTypes)
            {
                context.ItemTypes.Add(itemType);
            }
            context.SaveChanges();

            ItemInventory nutellaICPints = new ItemInventory() { Price = 9.99m, QtyOnHand = 5, Size = Size.Pint };
            context.ItemInventory.Add(nutellaICPints);

            ItemInventory nutellaICHPs = new ItemInventory() { Price = 4.99m, QtyOnHand = 2, Size = Size.HalfPint };
            context.ItemInventory.Add(nutellaICHPs);

            ItemInventory nanaPuddingQuarts = new ItemInventory() { Price = 12.99m, QtyOnHand = 7, Size = Size.Quart };
            context.ItemInventory.Add(nanaPuddingQuarts);

            ItemInventory nanaPuddingPints = new ItemInventory() { Price = 9.99m, QtyOnHand = 4, Size = Size.Pint };
            context.ItemInventory.Add(nanaPuddingPints);

            var items = new Item[]
            {
                new Item()
                {
                    ItemType = iceCream,
                    Name = "Nutella Ice Cream",
                    Description = "Homemade and slow-churned with Nutella",
                    ImageURL = "NutellaIceCream.png",
                    ItemInventory = new ItemInventory[] { nutellaICPints, nutellaICHPs }                                                                    
                },

                new Item()
                {
                    ItemType = pudding,
                    Name = "Chocolate Nana Pudding",
                    Description = "Homemade chocolate + banana pudding",
                    ImageURL = "ChocoNanaPudding.png",
                    ItemInventory = new ItemInventory[] { nanaPuddingQuarts, nanaPuddingPints }
                }
            };

            foreach(var item in items)
            {
                context.Items.Add(item);
            }
            context.SaveChanges();
        }
    }
}
