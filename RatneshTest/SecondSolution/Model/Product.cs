﻿using SecondSolution.Interface;

namespace SecondSolution.Model
{
    public class Product: IProduct
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public Product(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 15m;
                    break;
            }
        }       
    }

   
}
