using ConsoleRPG.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Models
{
    internal class Irk:BaseEntity,IStat
    {
        public Irk(string isim)
        {
            Isim = isim;
            switch (Isim.ToLower())
            {
                case "insan":
                    IradeMofikasyonu = 1;
                    break;
                case "ork":
                    GucMofikasyonu = 2;
                    break;
                case "elf":
                    IradeMofikasyonu = 1;
                    break;
                case "cuce":
                    DayaniklilikModifikasyonu = 2;
                    break;
                case "undead":
                    GucMofikasyonu = 3;
                    IradeMofikasyonu = 1;
                    break;
            }
        }
      public void StatBelirle(Karakter k)
        {
            switch (Isim.ToLower())
            {
                case "elf":
                   k. Ceviklik += CeviklikMofikasyonu;
                    break;
                case "insan":
                   k. Irade += IradeMofikasyonu;
                    break;
                case "ork":
                   k.Guc += GucMofikasyonu;
                    break;
                case "cuce":
                    k.Dayaniklilik += DayaniklilikModifikasyonu;
                    break;
                case "undead":
                   k.Guc += GucMofikasyonu;
                   k.Irade += IradeMofikasyonu;
                    break;
            }
        }

        public int GucMofikasyonu { get; set; }
        public int CeviklikMofikasyonu { get; set; }
        public int IradeMofikasyonu { get; set; }
        public int DayaniklilikModifikasyonu { get; set; }
        public List<Karakter> Karakterler { get; set; }
        public Sehir BaslangicSehri { get; set; }
    }
}
