using System;

namespace EjercicioAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Seleccione una fórmula:");
                Console.WriteLine("1. Área de un triángulo");
                Console.WriteLine("2. Volumen de un cilindro");
                Console.WriteLine("3. Hipotenusa de un triángulo rectángulo");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.\n");
                    continue;
                }

                FormulaMatematica formula = null;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la base del triángulo: ");
                        double baseTriangulo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo: ");
                        double alturaTriangulo = double.Parse(Console.ReadLine());
                        formula = new AreaTriangulo(baseTriangulo, alturaTriangulo);
                        break;
                    case 2:
                        Console.Write("Ingrese el radio del cilindro: ");
                        double radio = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del cilindro: ");
                        double alturaCilindro = double.Parse(Console.ReadLine());
                        formula = new VolumenCilindro(radio, alturaCilindro);
                        break;
                    case 3:
                        Console.Write("Ingrese el primer cateto del triángulo: ");
                        double catetoA = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo cateto del triángulo: ");
                        double catetoB = double.Parse(Console.ReadLine());
                        formula = new HipotenusaTriangulo(catetoA, catetoB);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (formula != null)
                {
                    formula.Calcular();
                    formula.Imprimir();
                }

                Console.WriteLine();

            } while (opcion != 4);
        }
    }
}

