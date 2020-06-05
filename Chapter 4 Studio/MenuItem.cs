﻿using System;


namespace Chapter_4_Studio
{
   public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }


        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

    }
}
