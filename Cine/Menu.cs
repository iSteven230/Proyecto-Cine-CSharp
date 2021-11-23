using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    class Menu
    {
        //sirve para tener un menu del cine
        public static void menu()
        {
            int dato = 0, confirmar;
            Console.WriteLine("******");
            Console.WriteLine("*  Cine  *");
            Console.WriteLine("******");
            do
            {
                Console.WriteLine("Digite 1 para ver la cartelera: ");
                Console.WriteLine("Digite 2 si desea salir: ");
                dato = int.Parse(Console.ReadLine());
                if(dato >= 3)
                {
                    Console.WriteLine("dato no valido, digite un numero correto");
                }
                if (dato == 2)
                {
                    Console.WriteLine("Está seguro?");
                    Console.WriteLine("1. confirmar");
                    Console.WriteLine("2. no");
                    confirmar = int.Parse(Console.ReadLine());
                    if (confirmar == 1)
                    {
                        Environment.Exit(1);
                    }
                    else
                        Menu.menu();
                }
            } while (dato > 3);
            Console.Clear();
            Cartelera.cartelera();                              //si es correcto todo va a la cartelera
           
        }
    }
}
