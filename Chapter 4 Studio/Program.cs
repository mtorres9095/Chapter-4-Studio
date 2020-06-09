using System;
using System.Collections.Generic;

namespace Chapter_4_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem sandwish = new MenuItem(5.75, "Ham and Egg Sandwish", "Breakfast", true);
            MenuItem hamburger = new MenuItem(7.80, "Cheese Burger with Fries", "Lunch", false);
            MenuItem salad = new MenuItem(4.99, "House Salad", "Appetizer", true);

            DateTime today = DateTime.Now;

            List<MenuItem> itemsList = new List<MenuItem> { sandwish, hamburger, salad };

            Menu ourMenu = new Menu(today, itemsList);

            //ourMenu.Print();

            MenuItem pancakes = new MenuItem(6.35, "Pan Cakes", "Breakfast", true);

            ourMenu.AddItem(pancakes);

            //ourMenu.Print();

            ourMenu.RemoveItem(hamburger);

            ourMenu.Print();

            //pancakes.Print();

            ourMenu.AddItem(sandwish);

            ourMenu.Print();

        }
    }
}
