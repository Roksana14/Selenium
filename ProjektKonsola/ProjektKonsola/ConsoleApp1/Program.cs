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
			string akcja = string.Empty;
			Skarbonka mojaSkarbonka = new Skarbonka();
			mojaSkarbonka.WyswietlDostepneAkcje();
			while (akcja != "4")
			{
				akcja = Console.ReadLine();
				switch (akcja)
				{
					case "1": Console.WriteLine("Twoja zawartość skarbonki to:");
						      Console.WriteLine(mojaSkarbonka.ZawartoscSkarbonki);
						break;
					case "2": Console.WriteLine("Podaj kwotę jaką chcesz włożyć do skarbonki");
						      kwota = int.Parse(Console.ReadLine());
						      mojaSkarbonka.WlozPieniadze(kwota);
						break;
					case "3": Console.WriteLine("Podaj kwotę jaką chcesz wyłożyć ze skarbonki");
						      kwota = int.Parse(Console.ReadLine());
						break;

					case "5": mojaSkarbonka.WyswietlDostepneAkcje();
						break;
					case "4":
						break;
					default:Console.WriteLine(" Twoja akcja jest nieprawidłowa");
						    mojaSkarbonka.WyswietlDostepneAkcje();
						break;
				}

				//if (akcja == "1")
				//{
				//	Console.WriteLine("Twoja zawartość skarbonki to:");
				//	Console.WriteLine(mojaSkarbonka.ZawartoscSkarbonki);
				//}
				//else if (akcja == "2")
				//{
				//	Console.WriteLine("Podaj kwotę jaką chcesz włożyć do skarbonki");
				//	kwota = int.Parse(Console.ReadLine());
				//	mojaSkarbonka.WlozPieniadze(kwota);
				//}
				//else if (akcja == "3")
				//{
				//	Console.WriteLine("Podaj kwotę jaką chcesz wyłożyć ze skarbonki");
				//	kwota = int.Parse(Console.ReadLine());

				//	if (mojaSkarbonka.ZawartoscSkarbonki > kwota)
				//	{
				//		mojaSkarbonka.WyjmijPieniadze(kwota);
				//	}
				//	else
				//	{

				//		Console.WriteLine("Nie możesz wybrać tylu piniądzów");
				//	}
				//}
				//else if (akcja == "5")
				//{
				//	mojaSkarbonka.WyswietlDostepneAkcje();
				//}

			}


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

			public void WyswietlDostepneAkcje()
			{
				Console.WriteLine("1-Wyświetl zawartość skarbonki");
				Console.WriteLine("2-Włóż pieniądz");
				Console.WriteLine("3-Wyłóż pieniądze");
				Console.WriteLine("4-Zakończ program");
				Console.WriteLine("5-Wyświetl dostępne akcje");
			}

        }
    }
}
