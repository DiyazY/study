using System;
using System.Linq;

namespace continuous_backpack
{
    class Program
    {
        struct item{
            public double c{get;set;}
            public double w{get;set;}
        }
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int W = int.Parse(firstLine[1]);
            item[] items = new item[n];
            for (int i = 0; i < n; i++)
            {
                var item = Console.ReadLine().Split(' ');
                items[i] = new item{c = double.Parse(item[0]),w=double.Parse(item[1]) };
            }
            items = items.ToList().OrderByDescending(p=>p.w).OrderByDescending<item, double>(p => {
               return p.c/p.w;
            }).ToArray();
            // for (int i = 0; i < n; i++)
            // {
            //     System.Console.WriteLine($"{items[i].c/items[i].w} : {items[i].c} {items[i].w}");
            // }
            double fulling = 0;
            double price = 0.0;
            for (int i = 0; i < n; i++)
            {
                if(items[i].w < (W-fulling)) {
                    fulling+=items[i].w;
                    price+=items[i].c;
                }
                else {
                    var diff = W-fulling;
                    fulling+=diff;
                    price+=items[i].c*diff / items[i].w;
                }
                if(W-fulling == 0) break;
            }
            System.Console.WriteLine(price.ToString("0.###"));
        }
    }
}
