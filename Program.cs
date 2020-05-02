using System;

namespace Listas_ligadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int opcionMenu = 0;
            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("----------------------");
                Console.WriteLine("1.- Insertar");
                Console.WriteLine("2.- Buscar");
                Console.WriteLine("3.- Desplegar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("----------------------");
                Console.WriteLine("Escoja una Opcion");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n Inserta Dato en la Lista\n");
                        l.insertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n Buscar Dato en la Lista\n");
                        l.buscarNodo();
                        break;
                    case 3:
                        Console.WriteLine("\n Desplegar Lista de Datos\n");
                        l.desplegarLista();
                        break;
                    case 4:
                        Console.WriteLine("\n Eliminar Datos de la lista\n");
                        l.eliminarNodo();
                        break;
                    case 5:
                        Console.WriteLine("\n Fin de Programa\n");
                        break;
                }
            }
            while (opcionMenu != 5);

        }
    }
}
