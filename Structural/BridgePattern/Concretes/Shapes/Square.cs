namespace BridgePattern.Concretes.Shapes
{
    public class Square : Shape
    {
        public Square(Brush brush) : base(brush) { }

        public override void ShapeOperation()
        {
            Console.WriteLine("Draw a square...");
            Brush.DrawShape();
        }
    }
}
