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
            Sinif savasci = new Sinif("savasci");
            Sinif okcu = new Sinif("okcu");
            Sinif buyucu = new Sinif("buyucu");
            Sinif sovalye = new Sinif("sovalye");
            Sinif ninja = new Sinif("ninja");

            Irk insan = new Irk("insan");
            Irk elf = new Irk("elf");
            Irk ork = new Irk("cuce");
            Irk undead = new Irk("undead");
           
            bool dogru=false;
            while (!dogru)
            {
                Console.WriteLine("Lütfen giriş yapmak için kulanıcı isminizi giriniz!");
                string isim = Console.ReadLine();
                Console.WriteLine("Lütfen şifenizi giriniz!");
                string sifre = Console.ReadLine();

                if (isim == "Bilal" && sifre == "1234")
                {
                    dogru= true;    
                    Console.WriteLine("Oyuna hoşgeldin... Karakter yaratmaya hazırsın. Karakterinin ismini giriniz!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı Bulunamadı Bilgileri Kontrol Ediniz!");
                    dogru= false;
                }
            }

            string karakterİsmi = Console.ReadLine();
            string sinifSecimi;
            Sinif secilenSinif = null;
            do
            {
                Console.WriteLine("Karakterinizin sınıfını seçiniz \n 1: Savasci \n 2:Okcu \n 3: Buyucu \n 4:Sovalye \n 5:Ninja ... FARKLI BİR SEÇENEK BULUNMADIĞINDAN VAR OLAN SINIFLAR İLE İLERLEYEBİLİRİZ !");
                sinifSecimi = Console.ReadLine();
                switch (sinifSecimi)
                {
                    case "1":
                        secilenSinif = savasci;
                        break;
                    case "2":
                        secilenSinif = okcu;
                        break;
                    case "3":
                        secilenSinif = buyucu;
                        break;
                    case "4":
                        secilenSinif = sovalye;
                        break;
                    case "5":
                        secilenSinif = ninja;
                        break;
                }

            } while (sinifSecimi != "1" && sinifSecimi != "2" && sinifSecimi != "3" && sinifSecimi != "4" && sinifSecimi != "5");
        }
    }
}
