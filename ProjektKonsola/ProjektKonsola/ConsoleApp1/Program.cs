using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kwota = 1;
            Skarbonka mojaSkarbonka = new Skarbonka();
            while (mojaSkarbonka.ZawartoscSkarbonki <= 20)
            {
                Console.WriteLine("Podaj kwotę jaką chcesz włożyć do skarbonki");
                kwota = int.Parse(Console.ReadLine());
                mojaSkarbonka.WlozPieniadze(kwota);
                Console.WriteLine("Twoja zawartość skarbonki to:");
                Console.WriteLine(mojaSkarbonka.ZawartoscSkarbonki);
                Console.WriteLine("Podaj kwotę jaką chcesz wyłożyć ze skarbonki");
                kwota = int.Parse(Console.ReadLine());
                if(mojaSkarbonka.ZawartoscSkarbonki > kwota)
                {
                    mojaSkarbonka.WyjmijPieniadze(kwota);
                }
                else
                {
                    Console.WriteLine("Nie możesz wybrać tylu piniądzów");
                }
                Console.WriteLine("Twoja zawartość skarbonki to:");
                Console.WriteLine(mojaSkarbonka.ZawartoscSkarbonki);
            }
            Console.ReadLine();


        }
        class Skarbonka
        {
            private int zawartoscSkarbonki = 0;

            public int ZawartoscSkarbonki { get => zawartoscSkarbonki;}

            public void WlozPieniadze(int piniadz)
            {
                zawartoscSkarbonki = piniadz + ZawartoscSkarbonki;
            }

            public void WyjmijPieniadze(int piniadz)
            {
                zawartoscSkarbonki = ZawartoscSkarbonki - piniadz;
            }
        }
    }
}
