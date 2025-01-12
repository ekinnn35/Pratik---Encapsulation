using System;
using ArabaUygulamasi; // Araba sınıfını kullanmak için gerekli namespace

namespace ArabaUygulamasiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Geçerli kapı sayısı olan bir araba oluşturuyoruz
            Araba araba1 = new Araba
            {
                Marka = "Toyota", // Marka bilgisi atanıyor
                Model = "Corolla", // Model bilgisi atanıyor
                Renk = "Beyaz", // Renk bilgisi atanıyor
                KapiSayisi = 4 // Geçerli bir kapı sayısı atanıyor
            };

            // Geçersiz kapı sayısı olan bir araba oluşturuyoruz
            Araba araba2 = new Araba
            {
                Marka = "Honda", // Marka bilgisi atanıyor
                Model = "Civic", // Model bilgisi atanıyor
                Renk = "Kırmızı", // Renk bilgisi atanıyor
                KapiSayisi = 3 // Geçersiz bir kapı sayısı atanıyor (Uyarı verecek)
            };

            // Araba bilgilerini yazdırma
            araba1.BilgiYazdir(); // Geçerli araba bilgileri
            araba2.BilgiYazdir(); // Geçersiz kapı sayısı (-1) ile araba bilgileri

            Console.ReadKey(); // Konsolu açık tutar
        }
    }
}
