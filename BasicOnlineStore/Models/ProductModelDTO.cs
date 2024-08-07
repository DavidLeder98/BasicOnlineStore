﻿using System.ComponentModel;

namespace BasicOnlineStore.Models
{
    public class ProductModelDTO
    {
        [DisplayName("Id number")]
        public int Id { get; set; }


        [DisplayName("Product")]
        public string Name { get; set; }


        [DisplayName("Price")]
        public decimal Price { get; set; }


        public string PriceString { get; set; }


        [DisplayName("Description")]
        public string Description { get; set; }


        public string ShortDescription { get; set; }


        public decimal Tax { get; set; }


        public ProductModelDTO(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;

            PriceString = "$" + price;
            ShortDescription = description.Length <= 25 ? description : description.Substring(0, 25);
            Tax = price * 0.08M;
        }

        public ProductModelDTO(ProductModel p)
        {
            Id = p.Id;
            Name = p.Name;
            Price = p.Price;
            Description = p.Description;

            PriceString = "$" + p.Price;
            ShortDescription = p.Description.Length <= 25 ? p.Description : p.Description.Substring(0, 25);
            Tax = p.Price * 0.08M;
        }
    }
}
