using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    class Menu
    {
        public static void menu()
        {
            int dato = 0;
            Console.WriteLine("*******Cine*******");
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
                    Environment.Exit(1);
                }
            } while (dato > 3);
            Console.Clear();
            Cartelera.cartelera();   
           
        }
    }
}
