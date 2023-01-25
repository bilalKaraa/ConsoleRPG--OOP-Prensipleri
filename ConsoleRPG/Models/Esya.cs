using ConsoleRPG.Enums;
using ConsoleRPG.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Models
{
    internal abstract class Esya:BaseEntity,IStat
    {
        public List<BonusOzellik> BonusOzellikler { get; set; }

        public int Bonus { get; set; }

        public virtual void StatBelirle(Karakter k)
        {
            foreach (BonusOzellik item in BonusOzellikler)
            {
                switch (item)
                {
                    case BonusOzellik.Guc:
                        k.Guc += Bonus;
                        break;
                    case BonusOzellik.Irade:
                        k.Irade+= Bonus;
                        break;
                    case BonusOzellik.Ceviklik:
                        k.Ceviklik+= Bonus;
                        break;
                    case BonusOzellik.Dayaniklilik:
                        k.Dayaniklilik+= Bonus;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
