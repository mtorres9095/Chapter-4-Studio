using System;
using System.Collections.Generic;


namespace Chapter_4_Studio
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
        }
        public List<MenuItem> AddItem(MenuItem item)
        {
            if (!Items.Contains(item))
            {
                Items.Add(item);
                LastUpdated = DateTime.Now;
            }
            else
            {
                Console.WriteLine("This Item Already Exist");
            }


            return Items;
        }

        public List<MenuItem> RemoveItem(MenuItem item)
        {
            Items.Remove(item);

            return Items;
        }
        public string MenuLastUpdated()
        {
            return $"The menu was last updated on {LastUpdated}";
        }

        public void Print()
        {
            Console.WriteLine("\n\n****** OUR MENU ******");

            foreach (MenuItem item in Items)
            {
                item.Print();
            }

            Console.WriteLine("**********************\n\n");
        }
    }
}

