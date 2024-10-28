namespace EjercicioAbstraccion
{
    public class VolumenCilindro : FormulaMatematica
    {
        private double Radio;
        private double Altura;
        private double Volumen;

        public VolumenCilindro(double radio, double altura)
        {
            Radio = radio;
            Altura = altura;
        }

        public override void Calcular()
        {
            Volumen = Math.PI * Math.Pow(Radio, 2) * Altura;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El volumen del cilindro es: {Volumen}");
        }
    }
}

