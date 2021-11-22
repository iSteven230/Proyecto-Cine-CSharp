using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    class ComprarComida
    {
        public string palomitas { get; set; }
        public string bebida { get; set; }
        public string dulce { get; set; }

        //sirve para poder entrar al menu y comprar lo que hay en el cine
        public static int Comprar()
        {
            Console.WriteLine("Que desea comprar: ");
            Console.WriteLine("1. Palomitas ");
            Console.WriteLine("2. Bebidas: ");
            Console.WriteLine("3. Dulces: ");
            Console.WriteLine("4. Atras: ");
            Console.WriteLine("5. Salir: ");

            int dato = int.Parse(Console.ReadLine());

            ComprarComida palomitas = new ComprarComida();
            palomitas.palomitas = "Y compro palomitas";
            ComprarComida bebida = new ComprarComida();
            bebida.bebida = "Y compro bebida";
            ComprarComida dulce = new ComprarComida();
            dulce.dulce = "Y compro dulce";
            List<ComprarComida> listacomida = new List<ComprarComida>();
            listacomida.Add(palomitas);
            listacomida.Add(bebida);
            listacomida.Add(dulce);
            
            switch (dato)
            {
                case 1:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.Clear();
                        Console.WriteLine(palomitas.palomitas);
                        Console.WriteLine("");
                        Cartelera.cartelera();
                    }
                    break;

                case 2:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.Clear();
                        Console.WriteLine(bebida.bebida);
                        Console.WriteLine("");
                        Cartelera.cartelera();
                    }
                    break;


                case 3:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.Clear();
                        Console.WriteLine(dulce.dulce);
                        Console.WriteLine("");
                        Cartelera.cartelera();
                    }
                    break;

                case 4:
                    Console.Clear();
                    Cartelera.cartelera();
                    break;

                case 5:
                    Menu.menu();
                    break; 

                default:
                    Console.WriteLine("numero no valido");
                    Comprar();
                    break;
            }
                return dato;
        }
    }
}
