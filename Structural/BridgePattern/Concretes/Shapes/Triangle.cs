namespace BridgePattern.Concretes.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(Brush brush) : base(brush) { }

        public override void ShapeOperation()
        {
            Console.WriteLine("Draw a triangle...");
            Brush.DrawShape();
        }
    }
}
