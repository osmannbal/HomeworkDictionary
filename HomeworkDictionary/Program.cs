using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ürünler = new MyDictionary<int, string>(); //sırayla ürünün ID'sini ve adını tanımlıyoruz.
            ürünler.Add(1, "Arduino");
            ürünler.Add(2, "RFID");
            ürünler.Add(3, "Raspberry Pi");
            ürünler.Add(4, "Potansiyometre");
            ürünler.Add(5, "DC Motor");
            ürünler.Add(6, "Transistör");
            Console.WriteLine(ürünler.Count + ürünler.Count2);

        }

    }
}