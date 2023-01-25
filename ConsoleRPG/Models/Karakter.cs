using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Models
{
    internal class Karakter : KarakterYaratıkSpec
    {

        public Karakter(Sinif sinif, Irk irk)
        {
            Seviye = 1;
            MaksimumCan = 100;
            MaksimumEnerji = 50;
            Sinifi = sinif;
            Irk = irk;
            sinif.StatBelirle(this);
            irk.StatBelirle(this);

        }
        public int Seviye { get; set; }

        int _maksimumCan;

        public override int MaksimumCan//Karakterin ilgili seviyede alabileceği maksimum can puanı
        {
            get
            {
                if (Seviye == 1 && _maksimumCan != 100)
                {
                    throw new Exception("Karakter 1. seviyede olmasına rağmen can puanında bir sorun tespit edildi!!");
                }
                return _maksimumCan;
            }
            set
            {
                if (Seviye == 1 && value == 100)
                {
                    _maksimumCan = value;
                }
                else if (Seviye > 1 && value > _maksimumCan)
                {
                    _maksimumCan = value;
                }
                else
                {
                    throw new Exception("Karakterin Can puanı ile ilgili bir sorun tespit edildi!!");
                }
            }
        }

        int _maksimumEnerji;
        public override int MaksimumEnerji
        {
            get
            {
                if (Seviye == 1 && _maksimumEnerji != 100)
                {
                    throw new Exception("Karakterinizin enerji seviyesinde 1. seviyede olan bir karakter için bir sorun tespit edildi!!");
                }
                return _maksimumEnerji;
            }

            set
            {
                if (Seviye == 1 && value == 50)
                {
                    _maksimumEnerji = value;
                }
                else if (Seviye > 1 && value > _maksimumEnerji)
                {
                    _maksimumEnerji = value;
                }
                else
                {
                    throw new Exception("Karakterinizin enerji seviyesinde bir sorun var kontrol ediniz!!");
                }
            }
        }
        public Irk Irk { get; set; }
        public int Para { get; set; }
        public int Guc { get; set; }
        public int Ceviklik { get; set; }
        public int Irade { get; set; }
        public int Dayaniklilik { get; set; }
        public Sinif Sinifi { get; set; }
        public Silah Silahi { get; set; }
        public Zirh Zirhi { get; set; }
        public Tilsim Tilsimi { get; set; }
        public override int YakinSaldiri()
        {
            int saldiri=Sinifi.Isim=="savasci" ||Sinifi.Isim=="sovalye" ? rnd.Next(1,21): rnd.Next(1,10);
            return base.YakinSaldiri() + Guc + Seviye;

            if (Silahi != null) return saldiri + Guc + Seviye + Silahi.Hasar;
            return saldiri + Guc + Seviye;
           
        }

        public override void OzelSaldiri()
        {
            throw new NotImplementedException();
        }

        public override int UzakSaldiri()
        {
            int saldiri =Sinifi.Isim=="okcu"|| Sinifi.Isim=="ninja" ? rnd.Next(1,21): rnd.Next(1,10);
            if (Silahi != null) return saldiri + Ceviklik + Seviye + Silahi.Hasar;
            return saldiri+Ceviklik+ Seviye;
        }
    }
}

