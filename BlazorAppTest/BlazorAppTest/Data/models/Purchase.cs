﻿namespace BlazorAppTest.Data.models
{
    public class Purchase
    {
        private readonly int _id;
        private float _price;
        private string _shop_name;
        private readonly Category _category;
        private readonly DateTime _datetime;
        public float Price { get { return _price; } set { _price = value; } }
        public string Shop_Name { get { return _shop_name; } set { _shop_name = value; } }
        public Category Category { get { return _category; } }

        public int Id { get { return _id; } }
        public DateTime DateTime { get { return _datetime; } }
        public Purchase(string shop_name, float price, Category category)
        {
            Price = price;
            Shop_Name = shop_name;
            _category = category;
            _datetime = DateTime.Now;
        }
        public Purchase()
        {

        }




    }
}
