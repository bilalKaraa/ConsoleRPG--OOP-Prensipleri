using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Models
{
    internal abstract class BaseEntity
    {
        public string Isim { get; set; }
        public DateTime? VeriYaratmaTarihi { get; set; }
        public DateTime? VeriDegistirmeTarihi { get; set; }
        public DateTime? VeriSilmeTarihi { get; set; }


    }
}
