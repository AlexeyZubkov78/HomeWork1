﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var dictionary = Dictionary.GetDictonary();

            Game.play(dictionary);
            Console.ReadKey();
        }
    }
}
