﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public abstract class Array
    {
        public int[] Mas { get; set; }
        public Array(int size)
        {
            Mas = new int[size];
            Random random = new Random();
            for(int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = random.Next(10, 100);
            }
        }
        public void Print()
        {
            foreach(int i in Mas)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        public abstract void Add(Array mas);
        public abstract void Foreach();
    }
}
