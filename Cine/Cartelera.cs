using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    class Cartelera
    {

        public static void cartelera()
        {
            int opcion;
            Console.WriteLine("Peliculas Disponible:");
            Console.WriteLine("1. Jhon Wick 3, sala 1");
            Console.WriteLine("2. Aladdin, sala 2");
            Console.WriteLine("3. Avengers, sala 3");
            Console.WriteLine("4. Pikachu, sala 4");
            Console.WriteLine("5. Atras");
            Console.WriteLine("Digite el numero correspondiente a la pelicula");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    SalaJhonWick.Menusalajhonwick();
                    break;

                case 2:
                    Console.Clear();
                    SalaAladdin.Menusalaaladdin();
                    break;

                case 3:
                    Console.Clear();
                    SalaAvengers.Menusalaavengers();
                    break;

                case 4:
                    Console.Clear();
                    SalaPikachu.Menusalapikachu();
                    break;

                case 5:
                    Menu.menu();
                    break;

                default:

                    break;
            }
        }
        public static void comprarboletojhonwick()
        {
            bool flag;
            int comprarfila;
            int comprarcolumna;
            do
            {

                Console.WriteLine("digite el numero de fila");
                comprarfila = int.Parse(Console.ReadLine());
                Console.WriteLine("digite el numero de columna");
                comprarcolumna = int.Parse(Console.ReadLine());
                flag = SalaJhonWick.verificarasientos(comprarfila, comprarcolumna);
            } while (!flag);
                SalaJhonWick.comprarboletojhonwick(comprarfila,comprarcolumna);
        }
        public static void comprarboletoaladdin()
        {
            bool flag;
            int comprarfila;
            int comprarcolumna;
            do
            {
                Console.WriteLine("digite el numero de fila");
                comprarfila = int.Parse(Console.ReadLine());
                Console.WriteLine("digite el numero de columna");
                comprarcolumna = int.Parse(Console.ReadLine());
                flag = SalaJhonWick.verificarasientos(comprarfila, comprarcolumna);
            } while (!flag);
            SalaJhonWick.comprarboletojhonwick(comprarfila, comprarcolumna);
        }
        public static void comprarboletoavengers()
        {
            bool flag;
            int comprarfila;
            int comprarcolumna;
            do
            {
                Console.WriteLine("digite el numero de fila");
                comprarfila = int.Parse(Console.ReadLine());
                Console.WriteLine("digite el numero de columna");
                comprarcolumna = int.Parse(Console.ReadLine());
                flag = SalaJhonWick.verificarasientos(comprarfila, comprarcolumna);
            } while (!flag);
            SalaJhonWick.comprarboletojhonwick(comprarfila, comprarcolumna);
        }
        public static void comprarboletopikachu()
        {
            bool flag;
            int comprarfila;
            int comprarcolumna;
            do
            {
                Console.WriteLine("digite el numero de fila");
                comprarfila = int.Parse(Console.ReadLine());
                Console.WriteLine("digite el numero de columna");
                comprarcolumna = int.Parse(Console.ReadLine());
                flag = SalaJhonWick.verificarasientos(comprarfila, comprarcolumna);
            } while (!flag);
            SalaJhonWick.comprarboletojhonwick(comprarfila, comprarcolumna);
        }
    }
}
