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
            Irk ork = new Irk("ork");
            Irk elf = new Irk("elf");
            Irk cuce = new Irk("cuce");
            Irk undead = new Irk("undead");

            string isim = "";
            string sifre = "";

            bool dogru=false;
            while (!dogru)
            {
                Console.WriteLine("Lütfen giriş yapmak için kulanıcı isminizi giriniz!");
                isim= Console.ReadLine();
                Console.WriteLine("Lütfen şifenizi giriniz!");
                sifre = Console.ReadLine();

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
                Console.WriteLine("Karakterinizin sınıfını seçiniz \n 1: Savasci \n 2: Okcu \n 3: Buyucu \n 4: Sovalye \n 5: Ninja ... FARKLI BİR SEÇENEK BULUNMADIĞINDAN VAR OLAN SINIFLAR İLE İLERLEYEBİLİRİZ !");
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

            string irkSecimi;
            Irk secilenIrk = null;
            do
            {
                Console.WriteLine("Karakterinizin Irkını seçiniz \n1:İnsan \n2:Ork \n3:Elf \n4:Cüce \n5:Undead.... FARKLI BİR SEÇENEK BULUNMADIĞINDAN VAR OLAN IRKLAR İLE İLERLEYEBİLİRİZ ! ");
                irkSecimi = Console.ReadLine();
                switch (irkSecimi)
                {
                    case"1":
                        secilenIrk = insan;
                        break;

                        case "2":
                        secilenIrk = ork;
                        break;

                        case "3":
                        secilenIrk = elf;
                        break;

                        case "4":
                        secilenIrk = cuce;
                        break;

                        case "5":
                        secilenIrk = undead;
                        break;
                }

            } while (irkSecimi != "1" && irkSecimi != "2" && irkSecimi != "3" && irkSecimi != "4" && irkSecimi != "5");
            Karakter k =new Karakter(secilenSinif,secilenIrk);
            k.Isim = isim;
            Console.WriteLine($"Karakterinizin ismi=>{k.Isim}... Karakterinizin sınıfı=>{k.Sinifi.Isim}...Irkınız=>{k.Irk.Isim}...Defansınız=>{k.Defans}...Seviyeniz=>{k.Seviye}");
            string oyunModuSecimi;
            do
            {
                Console.WriteLine("Ne yapmak istiyorsunuz? \n1:Macera \n2:Dinlenmek \n3:Gorev \n4:AlışVeriş\n VAR OLAN SEÇENEKLER DIŞINDA İŞLEM YAPAMAZSINZ!");

                oyunModuSecimi = Console.ReadLine();

                if (oyunModuSecimi=="1")
                {
                    Yaratik y = new Yaratik();
                    y.Defans = k.Seviye * 10;
                    y.MevcutCan = y.MaksimumCan = k.Seviye * 50;
                    Console.WriteLine($"Karşıınıza çıkan yaratığın canı=>{y.MaksimumCan}, defansı=>{y.Defans}... Saldırı başlıyor...Lütfen seçim yapın...\n1: Yakın Saldırı \n2: Uzak Saldırı \n Seçim yapılmadığı takdirde var sayılan saldırı türü olarak Yakın Saldırı yapılacaktır!!");
                    bool dovusDevam = true;
                    do
                    {
                       
                       
                        string saldiriSecimi = Console.ReadLine();
                        switch (saldiriSecimi)
                        {
                            case "1":
                            default:
                                int yakinSaldiri = k.YakinSaldiri() - y.Defans;
                                if (yakinSaldiri <= 0) yakinSaldiri = 0;
                                y.MevcutCan -= yakinSaldiri;
                                int yaratikSaldirisi = y.YakinSaldiri() - k.Defans;
                                if (yaratikSaldirisi <= 0) yaratikSaldirisi = 0;
                                k.MevcutCan-= yaratikSaldirisi;
                                break;
                                case "2":
                                int uzakSaldiri = k.UzakSaldiri() - y.Defans;
                                if (uzakSaldiri <= 0) uzakSaldiri = 0;
                                y.MevcutCan -= uzakSaldiri;
                                int yaratikUzakSaldirisi = y.YakinSaldiri() - k.Defans;
                                if (yaratikUzakSaldirisi <= 0) yaratikUzakSaldirisi = 0;
                                k.MevcutCan -= yaratikUzakSaldirisi;
                                break; 
                        }
                        if (y.MevcutCan<=0)
                        {
                            Console.WriteLine("Tebrikler yaratığı öldürüp bu macerayı sonlandırdınız!!");
                            dovusDevam = false;
                            continue;
                        }
                        Console.WriteLine($"Saldırı yapıldı. Yaratığın kalan canı=> {y.MevcutCan}...Sizin kalan canınız=>{k.MevcutCan}...Devam etmek istiyor musunuz? \n1:Devam \n2:Çıkış \n Varsayılan devam");
                        string macera=Console.ReadLine();
                        switch (macera)
                        {
                            case "2":
                                dovusDevam = false;
                                break;
                        }

                    } while (dovusDevam);
                }
                else if (oyunModuSecimi=="5")
                {
                    Console.WriteLine("Maceradan çıkış yapılıyor");
                    break;

                }

            } while (oyunModuSecimi!="1" && oyunModuSecimi!="2" && oyunModuSecimi!="3" && oyunModuSecimi!="4" && oyunModuSecimi!="5" );
        }
    }
}
