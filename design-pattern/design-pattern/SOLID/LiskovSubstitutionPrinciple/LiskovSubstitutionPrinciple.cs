/// <summary>
/// Objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.
/// </summary>
namespace design_pattern.LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle(){}

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    public class CalculateArea
    {
        public int Area(Rectangle r) 
        {
            return r.Width* r.Height; 
        }
    }
}
