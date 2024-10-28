namespace EjercicioAbstraccion
{
    public class HipotenusaTriangulo : FormulaMatematica
    {
        private double CatetoA;
        private double CatetoB;
        private double Hipotenusa;

        public HipotenusaTriangulo(double catetoA, double catetoB)
        {
            CatetoA = catetoA;
            CatetoB = catetoB;
        }

        public override void Calcular()
        {
            Hipotenusa = Math.Sqrt(Math.Pow(CatetoA, 2) + Math.Pow(CatetoB, 2));
        }

        public override void Imprimir()
        {
            Console.WriteLine($"La hipotenusa del triángulo es: {Hipotenusa}");
        }
    }
}
