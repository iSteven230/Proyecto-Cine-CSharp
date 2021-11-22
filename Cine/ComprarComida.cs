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


        public static int Comprar()
        {
            Console.Clear();
            Console.WriteLine("Que desea comprar: ");
            Console.WriteLine("1. Palomitas ");
            Console.WriteLine("2. Bebidas: ");
            Console.WriteLine("3. Dulces: ");
            Console.WriteLine("4. Atras: ");
            Console.WriteLine("5. salir");
                int dato = int.Parse(Console.ReadLine());
                do
                {
                    if (dato >= 4)
                    {
                        Console.WriteLine("dato no valido, digite un numero correto");
                    }
                    if (dato == 4)
                    {
                        break;
                    }
                } while (dato > 5);


            ComprarComida palomitas = new ComprarComida();
            palomitas.palomitas = "Usted compro palomitas";
            ComprarComida bebida = new ComprarComida();
            bebida.bebida = "bebida";
            ComprarComida dulce = new ComprarComida();
            dulce.dulce = "dulce";
            List<ComprarComida> listacomida = new List<ComprarComida>();
            listacomida.Add(palomitas);
            listacomida.Add(bebida);
            listacomida.Add(dulce);
            

            switch (dato)
            {
                case 1:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.WriteLine(palomitas.palomitas);
                        Console.WriteLine("");
                        Cartelera.cartelera();
                    }
                    break;

                case 2:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.WriteLine(bebida.bebida);
                        Console.WriteLine("");
                        Cartelera.cartelera();
                    }
                    break;


                case 3:
                    foreach (ComprarComida item in listacomida)
                    {
                        Console.WriteLine(dulce.dulce);
                        Console.WriteLine("");
                        Cartelera.cartelera();
                    }
                    break;

                case 4:
                    Cartelera.cartelera();
                    break;

                case 5:
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
