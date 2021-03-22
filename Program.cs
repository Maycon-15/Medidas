using System;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string MedidaUsuario;
            double metros, centimetros, quilometros;

            Console.WriteLine("---------");
            Console.Write("Coloque abaixo a medida em metro para que ela possa ser transferida para centimetros (cm) e kilometros (KM): ");
            MedidaUsuario = Console.ReadLine();
            metros = Convert.ToDouble(MedidaUsuario);
            centimetros = metros * 100;
            quilometros = metros / 100;

            
            Console.WriteLine("----------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n---Equivalencia---");
            Console . ResetColor ();
            Console.WriteLine($"{centimetros:N2} cm");
            Console.WriteLine($"{metros:N1} m");
            Console.WriteLine($"{quilometros:N3} km");
            Console.WriteLine("----------");
        }
    }
}
