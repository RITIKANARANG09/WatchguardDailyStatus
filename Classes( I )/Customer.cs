using System;
using System.Collections.Generic;
namespace Classes
    {
    public class Customer
    {
        public int Id;
        public string Name;
        public char c;
        public readonly List<Order> orders;//=new List<Order>();
        //constructor overloading
        public Customer() { 
        orders = new List<Order>();
        }
        public Customer(int id, string name, char c)
            :this(name)
        {
            Id = id;
            this.c = c;
        }
        public Customer(string name)
        :this()
        { 
            Name = name;
        }
        /*public void Prompt()
        {
            orders = new List<Order>();
        }*/
    }
    }
