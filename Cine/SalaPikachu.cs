using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    public struct dato4
    {
        public String Pikachu;
    }
    class SalaPikachu
    {
        public static int topefila = 10;
        public static int topecolumna = 10;
        public static string[,] sala4 = new string[topefila, topecolumna];

        //esté es el menu de la sala Pikachu
        public static void Menusalapikachu()
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
                    SalaPikachu.SalaPikachusalallena();
                    SalaPikachu.imprimirsala();                     //si selecciona 1, le muestra la sala y sus asientos 
                    Cartelera.comprarboletopikachu();               //llama al metodo para comprar boleto
                    break;

                case 2:
                    SalaPikachu.SalaPikachusalallena();
                    SalaPikachu.imprimirsala();                     //si selecciona 2 sirve para mostrar los asientos disponible
                    SalaPikachu.Menusalapikachu();                  //para despues de nuevo llamar al menu de la sala
                    break;  

                case 3:
                    Console.Clear();
                    Cartelera.cartelera();                          //si selecciona 3, regresa al menu de la cartelera
                    break;
                    
                case 4:
                    Menu.menu();                                    //si selecciona 4 regres al menu principal del cine
                    break;

                default:
                    Console.WriteLine("Numero no valido");
                    Menusalapikachu();
                    break;
            }
        }
        //sirve para llenar los asientos de la sala 
        public static void SalaPikachusalallena()
        {
            Console.WriteLine("*****Sala 4*****");
            Console.WriteLine("");
            for (int i = 0; i < topecolumna; i++)
            {
                for (int j = 0; j < topefila; j++)
                {
                    if (i == 0)
                    {
                        sala4[i, j] = Convert.ToString(j);
                    }
                    else if (j == 0)
                    {
                        sala4[i, j] = Convert.ToString(i);
                    }
                    else if (sala4[i, j] == "O")
                    {
                        sala4[i, j] = "O";
                    }
                    else
                    {
                        sala4[i, j] = "D";
                    }

                }
            }
        }
        //sirve para imprimir la sala 
        public static void imprimirsala()
        {
            for (int i = 0; i < topecolumna; i++)
            {
                for (int j = 0; j < topefila; j++)
                {
                    Console.Write(sala4[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //sirve para verificar si los asientos estan llenos o no
        public static bool verificarasientos(int comprarfila, int comprarcolumna)
        {
            bool verificar = comprarfila > topefila || comprarcolumna > topecolumna || comprarfila == 0
                || comprarcolumna == 0;
            if (verificar)
            {
                Console.WriteLine("entrada incorrecta");
                return false;
            }
            else if (sala4[comprarfila, comprarcolumna] == "O")
            {
                Console.WriteLine("Este asiento ya fue comprado");
                return false;
            }
            return true;

        }
        //sirve para poder comprar el boleto
        public static void comprarboletopikachu(int comprarfila, int comprarcolumna)
        {
            sala4[comprarfila, comprarcolumna] = "O";
            Console.WriteLine("usted compro la sala 2 para la pelicula Pikachu");
            Console.WriteLine("");
            ComprarComida.Comprar();
            Console.WriteLine("");
            Menusalapikachu();

        }
    }
}
