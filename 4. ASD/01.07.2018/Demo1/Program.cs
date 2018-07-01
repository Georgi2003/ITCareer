﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        /* Разтеглив Масив */
        static void Main(string[] args)
        {
            ArrayList<string> list = new ArrayList<string>();

            Console.WriteLine("Length = {0}",list.Length);      
            Console.WriteLine("Capacity = {0}", list.Capacity); 

            list.Add("Иванчо");
            list.Add("Марийка");
            list.Add("Петкан");

            for (int i = 0; i < list.Length; i++) Console.WriteLine(list.Get(i));

            Console.WriteLine("Length = {0}", list.Length);
            Console.WriteLine("Capacity = {0}", list.Capacity);

            Console.WriteLine("Remove = {0}",list.RemoveAt(1));

            for (int i = 0; i < list.Length; i++) Console.WriteLine(list.Get(i));

            Console.WriteLine("Length = {0}", list.Length);    
            Console.WriteLine("Capacity = {0}", list.Capacity); 
        }
    }
}
