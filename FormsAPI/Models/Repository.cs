﻿namespace FormsAPI.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId=1, CategoryName="Telefon"});
            _categories.Add(new Category { CategoryId=2, CategoryName="Bilgisayar"});

            _products.Add(new Product {  ProductId=1, Name="Iphone 14", Price=40000, IsActive=true, Image="1.jpg",CategoryId=1});
            _products.Add(new Product {  ProductId=2, Name="Iphone 15", Price=50000, IsActive=true, Image="2.jpg",CategoryId=1});
            _products.Add(new Product {  ProductId=3, Name="Iphone 16", Price=60000, IsActive=true, Image="3.jpg",CategoryId=1});
            _products.Add(new Product {  ProductId=4, Name="Iphone 17", Price=70000, IsActive=true, Image="4.jpg",CategoryId=1});


            _products.Add(new Product {  ProductId=5, Name="Macbook Air", Price=80000, IsActive=true, Image="1.jpg",CategoryId=2});
            _products.Add(new Product {  ProductId=6, Name= "Macbook Pro", Price=90000, IsActive=true, Image="1.jpg",CategoryId=2});
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

    }

}
