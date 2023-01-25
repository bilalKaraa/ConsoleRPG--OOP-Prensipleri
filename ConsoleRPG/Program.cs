using ConsoleRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Irk ı = new Irk("insan");
            Sinif s = new Sinif("savasci");
            Karakter k = new Karakter(s, ı);
            Console.WriteLine(k.YakinSaldiri());
            Console.Read();
                
       
        }
    }
}
