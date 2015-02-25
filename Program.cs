
using System;
using System.Threading;

namespace Practica2
{
	class Program
	{
		public static void cronometro(){
			int horas=0;
			int minutos=0;
			int segundos=0;
			
			for (horas=0; horas <24; horas ++)
				for(minutos=0;  minutos<60; minutos ++)
					for(segundos=0; segundos<60; segundos++){
						Console.WriteLine(horas + " : " + minutos + " : " + segundos);
						Thread.Sleep(1000);
						Console.Clear();
					}
						
		}
		public static void Main(string[] args)
		{
			
		}
	}
}