using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
  
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);


        }
        public void Cikar(int sayi1,int sayi2)
        {
            int Cikar = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + Cikar);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int Carp = sayi1 * sayi2;
            Console.WriteLine("Sonuç : "+Carp);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int Bolme = sayi1 / sayi2 ;
            Console.WriteLine("Sonuç : "+Bolme);
        }
    }
}
