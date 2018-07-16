using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKonsola
{
	class Program
	{
		static void Main(string[] args)
		{
			int zmiennaA = 3;
			int zmiennaB = 6;
			Kalkulator kalkulator = new Kalkulator();
			Console.WriteLine("cześć");
			Console.WriteLine("Podaj zmienną A");
			zmiennaA = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj zmienną B");
			zmiennaB = int.Parse(Console.ReadLine());
			Console.WriteLine(kalkulator.Suma(zmiennaA, zmiennaB));
			Console.WriteLine(kalkulator.Odejmowanie(zmiennaA, zmiennaB));
			Console.WriteLine(kalkulator.Szybkie_mnożenie(zmiennaA, zmiennaB));
			Console.WriteLine(kalkulator.Dzielenie(zmiennaA, zmiennaB));
			Console.ReadLine();
		}
	}

	class Kalkulator
	{
		private int skladnik2;

		public int Suma(int skladnik1, int skladnik2)
		{
			int wynik = skladnik1 + skladnik2;
			return wynik;

		}
		public int Odejmowanie(int skladnik1, int skladnik2)
		{
			int wynik = skladnik1 - skladnik2;
			return wynik;
		}


		internal int Szybkie_mnożenie(int skladnik1, int skladnik2)
		{
			return skladnik1 * skladnik2;
			throw new NotImplementedException();
		}
		public int Dzielenie(int skladnik1, int skladnik2)
		{
			int wynik = skladnik1 / skladnik2;
			return wynik;
		}
	}
}
	
