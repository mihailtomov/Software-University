﻿using System;

namespace P03ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public decimal Cost 
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                else
                {
                    this.cost = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}