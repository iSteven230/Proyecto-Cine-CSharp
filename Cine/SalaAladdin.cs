using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{ 
    public struct dato2
    {
        public String Aladin;
    }

    class SalaAladdin
    {
        public static int topefila = 10;
        public static int topecolumna = 10;
        public static string[,] sala2 = new string[topefila, topecolumna];

        public static void Menusalaaladdin()
        {
            int dato;
            Console.WriteLine("1. Comprar boletos");
            Console.WriteLine("2. Ver asientos disponibles");
            Console.WriteLine("3. Atras");
            dato = int.Parse(Console.ReadLine());
            Console.Clear();
            do
            {
                if (dato >= 5)
                {
                    Console.WriteLine("dato no valido, digite un numero correto");
                }
                if (dato == 4)
                {
                    break;
                }
            } while (dato > 5);
            switch (dato)
            {
                case 1:
                    SalaAladdin.Salaaladdinsalallena();
                    SalaAladdin.imprimirsala();
                    Cartelera.comprarboletoaladdin();
                    break;

                case 2:
                    SalaAladdin.Salaaladdinsalallena();
                    SalaAladdin.imprimirsala();
                    SalaAladdin.Menusalaaladdin();
                    break;

                case 3:
                    Console.Clear();
                    Cartelera.cartelera();
                    break;

                case 4:
                    Menu.menu();
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    Menusalaaladdin();
                    break;
            }
        }
        public static void Salaaladdinsalallena()
        {
            Console.WriteLine("*****Sala 2*****");
            Console.WriteLine("");
            for (int i = 0; i < topecolumna; i++)
            {
                for (int j = 0; j < topefila; j++)
                {
                    if (i == 0)
                    {
                        sala2[i, j] = Convert.ToString(j);
                    }
                    else if (j == 0)
                    {
                        sala2[i, j] = Convert.ToString(i);
                    }
                    else if (sala2[i, j] == "O")
                    {
                        sala2[i, j] = "O";
                    }
                    else
                    {
                        sala2[i, j] = "D";
                    }

                }
            }
        }
        public static void imprimirsala()
        {
            for (int i = 0; i < topecolumna; i++)
            {
                for (int j = 0; j < topefila; j++)
                {
                    Console.Write(sala2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static bool verificarasientos(int comprarfila, int comprarcolumna)
        {
            bool verificar = comprarfila > topefila || comprarcolumna > topecolumna || comprarfila == 0
                || comprarcolumna == 0;
            if (verificar)
            {
                Console.WriteLine("entrada incorrecta");
                return false;
            }
            else if (sala2[comprarfila, comprarcolumna] == "O")
            {
                Console.WriteLine("Este asiento ya fue comprado");
                return false;
            }
            return true;

        }
        public static void comprarboletoaladdin(int comprarfila, int comprarcolumna)
        {
            sala2[comprarfila, comprarcolumna] = "O";
            Console.WriteLine("usted compro la sala 2 para la pelicula Aladdin");
            Console.WriteLine("");
            ComprarComida.Comprar();
            Console.WriteLine("");
            Menusalaaladdin();

        }
    }
}
