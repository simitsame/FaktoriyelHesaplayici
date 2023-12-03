using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyon
{
    public class faktoriyel
    {
        public double hesap(int a) 
        {                      
            double sonuc = 1;
            for(int i =2;i<=a;i++) 
            {
                sonuc = sonuc*i;
            }
            return sonuc;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            faktoriyel za = new faktoriyel();
            Console.WriteLine("Faktöriyelini Bulmak İstediğiniz Sayıyı Giriniz");
            int sayi =Convert.ToInt32(Console.ReadLine());
            if(sayi <0 ) 
            {
                Console.WriteLine("Negatif Sayıların Faktöriyeli Tanımsızdır.");
                Task.Delay(500).Wait();
                Console.WriteLine("Program 3 saniye içinde kapanacak.");
                Task.Delay(3000).Wait();
                Console.WriteLine("Program kapanıyor...");
                Task.Delay(500).Wait();
                Environment.Exit(0);
            }
            
            double fsonuc=za.hesap(sayi);
            Console.WriteLine("Girdiğiniz Sayının Faktöriyeli :" + fsonuc);
            Console.ReadKey();
            
        }
    }
}
