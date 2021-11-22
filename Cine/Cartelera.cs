using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    //en esta clase encuentra varios metodos, que sirve para ver la cartelera, etc
     class Cartelera
    {
        //sirve para ingresar a la cartelera del cine
        public static void cartelera()
        {
            int opcion;
            Console.WriteLine("Peliculas Disponible:");
            Console.WriteLine("********");
            Console.WriteLine("    Sala 1");
            Console.WriteLine("1. Jhon Wick 3");
            Console.WriteLine("*********");
            Console.WriteLine("    Sala 2");
            Console.WriteLine("2. Aladdin");
            Console.WriteLine("********");
            Console.WriteLine("    Sala 3");
            Console.WriteLine("3. Avengers");
            Console.WriteLine("*********");
            Console.WriteLine("    Sala 4");
            Console.WriteLine("4. Pikachu");
            Console.WriteLine("********");
            Console.WriteLine("5. Atras");
            Console.WriteLine("Digite el numero correspondiente a la pelicula");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.Clear();                        //sirve para quitar las lineas de la consola
                    SalaJhonWick.Menusalajhonwick();        //si digita 1 se va a la sala de Jhon Wick
                    break;

                case 2:
                    Console.Clear();                        //sirve para quitar las lineas de la consola
                    SalaAladdin.Menusalaaladdin();          //si digita 2 se va a la sala de Aladdin
                    break;

                case 3:
                    Console.Clear();                        //sirve para quitar las lineas de la consola
                    SalaAvengers.Menusalaavengers();        //si digita 3 se va a la sala de Avengers
                    break;

                case 4:
                    Console.Clear();                        //sirve para quitar las lineas de la consola
                    SalaPikachu.Menusalapikachu();          //si digita 4  se va a la sala de Pikachu
                    break;

                case 5:
                    Menu.menu();                            //si digita 5, se va a la clase Menu, quiere decir que va a retroceder en el programa
                    break;

                default:
                                                            //Si dijita otro numero, repite
                    break;
            }
        }
        //metodo que sirve para comprar el boleto de Jhon Wick 3
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
                flag = SalaJhonWick.verificarasientos(comprarfila, comprarcolumna);     //guarda las fila y columnas para ver comprobar en la siguiente linea si se encuentra disponible
            } while (!flag);                                                            //comprobar
                SalaJhonWick.comprarboletojhonwick(comprarfila,comprarcolumna);         //devuelve los datos a la Sala Jhon Wick al metodo comprarboleto
        }
        //metodo que sirve para comprar el boleto de Aladdin
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
                flag = SalaAladdin.verificarasientos(comprarfila, comprarcolumna);      //guarda las fila y columnas para ver comprobar en la siguiente linea si se encuentra disponible
            } while (!flag);                                                            //comprobar
            SalaAladdin.comprarboletoaladdin(comprarfila, comprarcolumna);              //devuelve los datos a la Sala Aladdin al metodo comprarboleto
        }
        //metodo que sirve para comprar el boleto de Avengers
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
                flag = SalaJhonWick.verificarasientos(comprarfila, comprarcolumna);     //guarda las fila y columnas para ver comprobar en la siguiente linea si se encuentra disponible
            } while (!flag);                                                            //comprobar
            SalaAvengers.comprarboletoavengers(comprarfila, comprarcolumna);            //devuelve los datos a la Sala Avengers al metodo comprarboleto
        }
        //metodo que sirve para comprar el boleto de Pikachu
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
                flag = SalaPikachu.verificarasientos(comprarfila, comprarcolumna);      //guarda las fila y columnas para ver comprobar en la siguiente linea si se encuentra disponible
            } while (!flag);                                                            //comprobar
            SalaPikachu.comprarboletopikachu(comprarfila, comprarcolumna);              //devuelve los datos a la Sala Pikachu al metodo comprarboleto
        }
    }
}
