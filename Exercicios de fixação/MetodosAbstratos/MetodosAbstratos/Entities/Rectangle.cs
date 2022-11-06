using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double heidht, Color color) : base(color)
        {
            Width = width;
            Height = heidht;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

}