using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen plaka sayı değerine göre şehir adını getiren program.
            Console.Write("Lütfen plaka kodu girin: ");
            string giris = Console.ReadLine();
            string sonuc;

            //if (giris == "06")
            //{
            //    sonuc = "Ankara";
            //}
            //else if (giris == "34")
            //{
            //    sonuc = "İstanbul";
            //}
            //else if (giris == "35")
            //{
            //    sonuc = "İzmir";
            //}
            //else if (giris == "26")
            //{
            //    sonuc = "Eskişehir";
            //}
            //else
            //{
            //    sonuc = "Girdiğiniz plaka sistemde bulunamadı.";
            //}
            switch (giris)
            {
                case "06": sonuc = "Ankara";
                    break;
                case "34": sonuc = "İstanbul";
                    break;
                case "35": sonuc = "İzmir";
                    break;
                case "26": sonuc = "Eskişehir";
                    break;
                default: sonuc = "Girdiğiniz plaka sistemde bulunamadı.";
                    break;
            }

            Console.WriteLine("Girdiğiniz plaka kodu: " + giris + ", plaka kodunun şehri: " + sonuc);

            Console.ReadLine();
        }
    }
}
