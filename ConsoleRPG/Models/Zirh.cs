using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Models
{
    internal class Zirh:Esya
    {
        public int Defans { get; set; }
        public override void StatBelirle(Karakter k)
        {
            base.StatBelirle(k);
            k.Defans += Defans;
        }
    }
}
