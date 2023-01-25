using ConsoleRPG.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Models
{
    internal class Sinif : BaseEntity,IStat
    {
        public List<Karakter> Karakterler { get; set; }
        public Sinif(string isim)
        {
            Isim = isim;
        }
        public void StatBelirle(Karakter k)
        {
            switch (Isim.ToLower())
            {
                case "savasci":
                    k.Guc = 3;
                    k.Ceviklik = 2;
                    k.Dayaniklilik = 2;
                    k.Irade = 1;
                    break;
                case "okcu":
                    k.Guc = 2;
                    k.Ceviklik = 3;
                    k.Dayaniklilik = 3;
                    k.Irade = 1;
                    break;
                case "buyucu":
                    k.Guc = 2;
                    k.Dayaniklilik = 1;
                    k.Irade = 3;
                    k.Ceviklik = 2;
                    break;
                case "sovalye":
                    k.Guc = 3;
                    k.Dayaniklilik = 2;
                    k.Irade = 3;
                    k.Ceviklik = 1;
                    break;
                case "ninja":
                    k.Guc = 2;
                    k.Dayaniklilik = 1;
                    k.Irade = 2;
                    k.Ceviklik = 3;
                    break;
            }
        }
    }
}
