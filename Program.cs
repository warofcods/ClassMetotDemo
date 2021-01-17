using System;
using System.Collections.Generic;
namespace tDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Merhabalar Nasıl Bir İşlem Yapmak İstersiniz?");
            Console.WriteLine("Müşteri Ekle / Müşteri Listele / Müşteri Sil Yazabilirsiniz");
            string islem = Console.ReadLine();


            List<string> YeniListem = new List<string>();
            YeniListem.Add("Mustafa");
            YeniListem.Add("Ahmet");
            YeniListem.Add("Veli");
            YeniListem.Add("Ali");




            switch (islem)
            {
                case "Müşteri Ekle":
                    Console.WriteLine("Eklemek İstediğiniz Müşteri Adı?");

                    YeniListem.Add(Console.ReadLine());
                    
                    Console.WriteLine("********  Yeni Liste   **********");
                    foreach (var musteri in YeniListem)
                    {
                        Console.WriteLine(musteri);
                    }

                    break;
                case "Müşteri Listele":
                    foreach (var musteri in YeniListem)
                    {
                        Console.WriteLine(musteri);
                    }
                    break;
                case "Müşteri Sil":
                    Console.WriteLine("********  Müşteriler   **********");
                    foreach (var musteri in YeniListem)
                    {
                        Console.WriteLine(musteri);
                    }

                    Console.WriteLine("Hangi Müşteriyi Silmek İstersiniz?");


                    YeniListem.Remove(Console.ReadLine());

                    Console.WriteLine("********  Yeni Liste   **********");
                    foreach (var musteri in YeniListem)
                    {
                        Console.WriteLine(musteri);
                    }


                    break;

            }


            {

                
            }
        }
    }
}
 