using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDemyanov.Shop.ShopWPF.Models
{
    internal class Guitar
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string ImagePath { get; set; }

        public Guitar()
        {   

        }

        public Guitar(int Id, string Title, decimal Price, string Category, string Brand, string ImagePath)
        {
            this.Id = Id;
            this.Title = Title;
            this.Price = Price;
            this.Category = Category;
            this.Brand = Brand;
            this.ImagePath = ImagePath;
        }
    }
}
