namespace BridgePattern.Concretes.Shapes
{
    public class Circle : Shape
    {
        public Circle(Brush brush) : base(brush) { }

        public override void ShapeOperation()
        {
            Console.WriteLine("Draw a circle...");
            Brush.DrawShape();
        }
    }
}
