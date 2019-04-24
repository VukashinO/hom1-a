﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Configuration : Item
    {
        public string Title { get; set; }
        public ConfigurationType Type { get; set; }
        public List<Module> Modules { get; set; }
        public Configuration()
        {
            Modules = new List<Module>();
        }
        public Configuration(int id, double price, double discount, string title, ConfigurationType type, List<Module> modules)
            : base(id, price, discount)
        {
            Title = title;
            Type = type;
            Modules = modules;
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Id} {Type} {Price}");
            Console.ResetColor();
            foreach (var item in Modules)
            {
                item.PrintInfo();
            }
        }
    }
}
