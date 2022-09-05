﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class ProductReview
    {
        public List<Product> ProductList = new List<Product>();

        // UC 1: Adding a Productreview details
        public int AddProductReview()
        {
            ProductList.Add(new Product() { ProductId = 03, UserId = 10, Review = "Bad", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductId = 02, UserId = 8, Review = "Average", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductId = 03, UserId = 7, Review = "Nice", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 04, UserId = 5, Review = "Good", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 06, UserId = 4, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 05, UserId = 6, Review = "Bad", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 06, UserId = 8, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 02, UserId = 9, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductId = 04, UserId = 5, Review = "Average", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductId = 06, UserId = 4, Review = "Bad", Rating = 3, IsLike = true });
            ProductList.Add(new Product() { ProductId = 07, UserId = 9, Review = "Bad", Rating = 1, IsLike = false });
            ProductList.Add(new Product() { ProductId = 06, UserId = 10, Review = "Nice", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 06, UserId = 3, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 02, UserId = 10, Review = "Nice", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductId = 02, UserId = 9, Review = "Bad", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 09, UserId = 12, Review = "Good", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 04, UserId = 14, Review = "Nice", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 05, UserId = 15, Review = "Average", Rating = 6, IsLike = true });
            ProductList.Add(new Product() { ProductId = 1, UserId = 10, Review = "Average", Rating = 2, IsLike = false });
            ProductList.Add(new Product() { ProductId = 1, UserId = 1, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 10, Review = "Average", Rating = 2, IsLike = false });
            ProductList.Add(new Product() { ProductId = 4, UserId = 7, Review = "Good", Rating = 4, IsLike = true });
            ProductList.Add(new Product() { ProductId = 5, UserId = 8, Review = "Bad", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductId = 3, UserId = 9, Review = "Nice", Rating = 7, IsLike = false });
            ProductList.Add(new Product() { ProductId = 5, UserId = 10, Review = "Average", Rating = 3, IsLike = true });

            return ProductList.Count;
        }

        //Display List Content
        public void DisplayList()
        {
            foreach (Product product in ProductList)
            {
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.ProductId, product.UserId, product.Review, product.Rating, product.IsLike);
            }
        }
    }
}
