using System.Security.Cryptography.X509Certificates;
using TrabajoIntegradorAyP;

class Program
{
    public static void Main(string[]args)
    {
        char opcion;

        
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("A) Contratar un obrero");
            Console.WriteLine("B) Eliminar un obrero");
            Console.WriteLine("C) Imprimir listado de obreros, de obras en ejecución con mas del %50 de avance, de obras finalizadas y de jefes");
            Console.WriteLine("D) Agregar una obra y asignarle un jefe");
            Console.WriteLine("E) Modificar el estado de avance de una obra");
            Console.WriteLine("F) Dar de baja a un jefe");
            Console.WriteLine();
            Console.WriteLine("seleccione una opción o presione X para salir...");

            opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (opcion != 'X');


        switch(opcion)
        {     
            case 'a':
                Console.Clear();
                contratarObrero();
                break;

            case 'b':
                Console.Clear();
                eliminarObrero();
                break;

            case 'c':
                Console.Clear();
                imprimirListado();
                break;

            case 'd':
                Console.Clear();
                agregarObra();
                break;

            case 'e':
                Console.Clear();
                modificarEstadoAvanceObra();
                break;

            case 'f':
                Console.Clear();
                darDeBajaJefe();
                break;
        }
    }




    public static void contratarObrero()
    {
        Console.WriteLine("contratar obrero");
    }

    
    public static void eliminarObrero()
    {
        Console.WriteLine("eliminar obrero");
    }

    public static void imprimirListado()
    {
        Console.WriteLine("imprimir listado");
    }


    public static void agregarObra()
    {
        Console.WriteLine("agregar obra y asignar jefe");
    }

    public static void modificarEstadoAvanceObra()
    {
        Console.WriteLine("modificar estado de avance de obra");
    }

    public static void darDeBajaJefe()
    {
        Console.WriteLine("dar de baja a un jefe");
    }



}
