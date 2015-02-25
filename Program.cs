
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
						Console.WriteLine("\n\tCRONOMETRO EN C#\n\n");
						Console.WriteLine("\t" + horas + " : " + minutos + " : " + segundos);
						Thread.Sleep(1000);
						Console.Clear();
					}
						
		}
		
		public static void reloj(){
			int horas=0;
			int minutos=0;
			int segundo=0;
			DateTime fecha= DateTime.Now;
			
			for (horas=fecha.Hour; horas <24; horas ++)
				for(minutos=fecha.Minute;  minutos<60; minutos ++)
					for(segundo=fecha.Second; segundo <60; segundo ++){
						fecha= DateTime.Now;
						Console.WriteLine("\n\tRELOJ EN C#\n\n");
						Console.WriteLine("La Hora Es : " + fecha.Hour + " : " + fecha.Minute +  " : " +  fecha.Second);
						Thread.Sleep(1000);
						Console.Clear();
					}
			
		}
		public static void Main(string[] args)
		{
			int opcion=0;
			
			do{
				Console.WriteLine("\n\tCRNOMETRO Y RELOJ EN C# \n\n");
				Console.WriteLine("1)Cronometro\n2)Reloj\n3)Salir\n");
				Console.WriteLine("Elige una opcion: ");
				opcion=int.Parse(Console.ReadLine());
				
				switch(opcion){
						case 1: Console.Clear();
								cronometro();
								break;
									
						case 2: Console.Clear();
								reloj();
								break;
				}	
			}while (opcion<3);
		}
	}
}