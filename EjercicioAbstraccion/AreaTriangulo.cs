namespace EjercicioAbstraccion
{
    public class AreaTriangulo : FormulaMatematica
    {
        private double BaseTriangulo;
        private double Altura;
        private double Area;

        public AreaTriangulo(double baseTriangulo, double altura)
        {
            BaseTriangulo = baseTriangulo;
            Altura = altura;
        }

        public override void Calcular()
        {
            Area = (BaseTriangulo * Altura) / 2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El área del triángulo es: {Area}");
        }
    }
}

