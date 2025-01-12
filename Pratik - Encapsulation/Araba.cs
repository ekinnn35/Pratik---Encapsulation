using System;

namespace ArabaUygulamasi
{
    public class Araba
    {
        // Arabanın Marka özelliği
        public string Marka { get; set; }

        // Arabanın Model özelliği
        public string Model { get; set; }

        // Arabanın Renk özelliği
        public string Renk { get; set; }

        // Kapı Sayısı için private bir field tanımlanıyor
        private int _kapiSayisi;

        // Kapı Sayısı property’si (Encapsulation)
        public int KapiSayisi
        {
            get
            {
                // Kapı sayısını döndür
                return _kapiSayisi;
            }
            set
            {
                // Kapı sayısı sadece 2 veya 4 olabilir
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    // Geçersiz bir kapı sayısı atanırsa uyarı mesajı göster
                    Console.WriteLine("Geçersiz Kapı Sayısı! (Sadece 2 veya 4 olabilir)");
                    _kapiSayisi = -1; // Kapı sayısına -1 atanır
                }
            }
        }

        // Araba bilgilerini yazdıran bir metot
        public void BilgiYazdir()
        {
            // Arabanın tüm bilgilerini konsola yazdır
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapiSayisi}");
        }
    }
}
