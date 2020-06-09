using System;


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
        public void Print()
        {
            Console.WriteLine(Category + " : " + Description + " : " + Price + "$");
        }
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            MenuItem itemObj = obj as MenuItem;
            return Description == itemObj.Description;

        }
    }
}
