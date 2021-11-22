using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    class SalaAvengers
    {
        public static int topefila = 10;
        public static int topecolumna = 10;
        public static string[,] sala3 = new string[topefila, topecolumna];

        public static void Menusalaavengers()
        {
            int dato;
            Console.WriteLine("1. Comprar boletos");
            Console.WriteLine("2. Ver asientos disponibles");
            Console.WriteLine("3. Atras");
            Console.WriteLine("4. Salir");
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
                    SalaAvengers.Salaavengerssalallena();
                    SalaAvengers.imprimirsala();
                    Cartelera.comprarboletoavengers();
                    break;

                case 2:
                    SalaAvengers.Salaavengerssalallena();
                    SalaAvengers.imprimirsala();
                    SalaAvengers.Menusalaavengers();
                    break;

                case 3:
                    Cartelera.cartelera();
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    Menusalaavengers();
                    break;
            }
        }
        public static void Salaavengerssalallena()
        {
            Console.WriteLine("*****Sala 3*****");
            Console.WriteLine("");
            for (int i = 0; i < topecolumna; i++)
            {
                for (int j = 0; j < topefila; j++)
                {
                    if (i == 0)
                    {
                        sala3[i, j] = Convert.ToString(j);
                    }
                    else if (j == 0)
                    {
                        sala3[i, j] = Convert.ToString(i);
                    }
                    else if (sala3[i, j] == "O")
                    {
                        sala3[i, j] = "O";
                    }
                    else
                    {
                        sala3[i, j] = "D";
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
                    Console.Write(sala3[i, j] + "\t");
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
            else if (sala3[comprarfila, comprarcolumna] == "O")
            {
                Console.WriteLine("Este asiento ya fue comprado");
                return false;
            }
            return true;
        }
        public static void comprarboletoavengers(int comprarfila, int comprarcolumna)
        {
            sala3[comprarfila, comprarcolumna] = "O";
            Console.WriteLine("sala comprada");
            Console.WriteLine("");
            ComprarComida.Comprar();
            Console.WriteLine("");
            Menusalaavengers();
        }
    }
}
