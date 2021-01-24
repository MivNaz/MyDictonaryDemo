using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictonaryDemo
{
    class Program
    {

        static void Main(string[] args)
        {
           
            List<Kitaplar> KitapKayit = new List<Kitaplar>

                {
                   new Kitaplar { Id=1, KitpAdi="Büyük Umutlar", Yazar="Charles Dickens", SayfaSayisi=600 },
                   new Kitaplar { Id=2, KitpAdi="Uğultulu Tepeler", Yazar="Emily Bronte", SayfaSayisi=408 },
                   new Kitaplar { Id=3, KitpAdi="Fırtınada Yanacaksın", Yazar="John Verdon", SayfaSayisi=520 },
                   new Kitaplar { Id=4, KitpAdi="Vampir Prensi", Yazar="Darren Shan", SayfaSayisi=175 },
                   new Kitaplar { Id=5, KitpAdi="Bir Kadının Yaşamından 24 Saat", Yazar="Stefan zweig", SayfaSayisi=86 }
                };

            Dictionary<int, Kitaplar> Liste = KitapKayit.ToDictionary(id => id.Id);


            foreach (var index in Enumerable.Range(1, 5))
            {
                Console.WriteLine($"Kitap {index}'in bilgileri: {Liste[index].Yazar} - {Liste[index].KitpAdi} Sy :{Liste[index].SayfaSayisi}");
            }

            


        }

    }
    class Kitaplar
    {
        public int Id { get; set; }
        public String KitpAdi { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
    }



}
    




