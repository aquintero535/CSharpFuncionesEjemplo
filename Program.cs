using System;

namespace ActividadFunciones
{
    class Program
    {
        static float pi = 3.14f; //Variable estática para ser usada en todas las funciones.
        static void Main(string[] args)
        {
            while (true)
            {
                var asteriscos = new System.Text.StringBuilder("*", 50);
                for (int i=0;i<49;i++)
                {
                    asteriscos.Append("*");
                }
                System.Console.WriteLine($"{asteriscos.ToString()}\nPROGRAMA PARA GEOMETRÍA\n{asteriscos.ToString()}");
                System.Console.WriteLine("\n¿Qué área desea calcular? \n(c) Círculo \n(r) Rectángulo \n(t) Triángulo \n(s) Salir");
                char opcion = Char.Parse(Console.ReadLine());
                if (opcion == 's')
                {
                    break;
                }
                float resultado = 0f;
                if (opcion == 'c')
                {
                    resultado = calcularAreaCirculo();
                } 
                else if (opcion == 'r')
                {
                    resultado = calcularAreaRectangulo();
                }
                else
                {
                    resultado = calcularAreaTriangulo();
                }
                System.Console.WriteLine($"El resultado es: {resultado}");
            }
            System.Console.WriteLine("Gracias por usar el programa de cálculo geométrico.");
        }

        public static float calcularAreaCirculo()
        {
            System.Console.WriteLine("Ingrese el radio: ");
            int vradio = Int32.Parse(Console.ReadLine());
            return pi*(vradio*vradio);
        }

        public static float calcularAreaRectangulo()
        {
            System.Console.WriteLine("Ingrese la base: ");
            int vbase = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese la altura: ");
            int valtura = Int32.Parse(Console.ReadLine());
            return vbase*valtura;
        }

        public static float calcularAreaTriangulo()
        {
            System.Console.WriteLine("Ingrese la base: ");
            int vbase = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese la altura: ");
            int valtura = Int32.Parse(Console.ReadLine());
            return (vbase*valtura)/2;
        }
    }
}
