using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            // Calculo padrão de aréa de um circulo = Raiz quadrada de PI X Raio ao quadrado.
            return Math.PI * Radius * Radius;
        }
    }
}