﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IntegerBox
{
    public class Box<T>
    {
        public int Count { get; private set; }

        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
            this.Count = 0;
        }

        public void Add(T element)
        {
            this.items.Add(element);
            this.Count++;
        }

        public T Remove()
        {
            T remove = this.items.Last();
            this.items.Remove(items.Last());
            this.Count--;
            return remove;
        }

        public void Print()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public override string ToString()
        {
            string temp = null, type = null;
            foreach (var item in items)
            {
                type = item.GetType().ToString();
                temp += item.ToString();
            };
            return $"{type}: {temp}";
        }
    }
}
