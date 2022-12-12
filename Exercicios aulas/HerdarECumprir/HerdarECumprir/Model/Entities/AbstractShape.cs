using HerdarECumprir.Model.Enums;

namespace HerdarECumprir.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
