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
        public string hotdog { get; set; }

        //sirve para poder entrar al menu y comprar lo que hay en el cine
        public static int Comprar()
        {
            Console.WriteLine("Que desea comprar: ");
            Console.WriteLine("1. Palomitas ");
            Console.WriteLine("2. Bebidas: ");
            Console.WriteLine("3. Dulces: ");
            Console.WriteLine("4. Hotdog");
            Console.WriteLine("5. Atras: ");
            Console.WriteLine("6. Salir: ");

            int dato = int.Parse(Console.ReadLine());

            ComprarComida palomitas = new ComprarComida();
            palomitas.palomitas = "Y compro palomitas";
            ComprarComida bebida = new ComprarComida();
            bebida.bebida = "Y compro bebida";
            ComprarComida dulce = new ComprarComida();
            dulce.dulce = "Y compro dulce";
            ComprarComida hotdog = new ComprarComida();
            hotdog.hotdog = "Y compro hotdog";
            List<ComprarComida> listacomida = new List<ComprarComida>();
            listacomida.Add(palomitas);
            listacomida.Add(bebida);
            listacomida.Add(dulce);
            listacomida.Add(hotdog);
            
            switch (dato)
            {
                case 1:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.Clear();
                        Console.WriteLine(palomitas.palomitas);
                        Console.WriteLine("");
                        Console.WriteLine("Desea comprar otra cosa?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        int confir = int.Parse(Console.ReadLine());
                        if (confir == 1)
                        {
                            ComprarComida.Comprar();
                        }
                        else
                        Cartelera.cartelera();
                    }
                    break;

                case 2:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.Clear();
                        Console.WriteLine(bebida.bebida);
                        Console.WriteLine("");
                        Console.WriteLine("Desea comprar otra cosa?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        int confir = int.Parse(Console.ReadLine());
                        if (confir == 1)
                        {
                            ComprarComida.Comprar();
                        }
                        else
                            Cartelera.cartelera();
                    }
                    break;


                case 3:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.Clear();
                        Console.WriteLine(dulce.dulce);
                        Console.WriteLine("");
                        Console.WriteLine("Desea comprar otra cosa?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        int confir = int.Parse(Console.ReadLine());
                        if (confir == 1)
                        {
                            ComprarComida.Comprar();
                        }
                        else
                            Cartelera.cartelera();
                    }
                    break;

                case 4:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.Clear();
                        Console.WriteLine(hotdog.hotdog);
                        Console.WriteLine("");
                        Console.WriteLine("Desea comprar otra cosa?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        int confir = int.Parse(Console.ReadLine());
                        if (confir == 1)
                        {
                            ComprarComida.Comprar();
                        }
                        else
                            Cartelera.cartelera();
                    }
                    break;

                case 5:
                    Console.Clear();
                    Cartelera.cartelera();
                    break;

                case 6:
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
