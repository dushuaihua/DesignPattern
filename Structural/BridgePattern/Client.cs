
using BridgePattern.Concretes.Shapes;

namespace BridgePattern
{
    public class Client
    {
        public void DrawRedSquare()
        {
            var brush = new RedBrush();
            var square = new Square(brush);
            square.ShapeOperation();
        }

        public void DrawBlueTriangle()
        {
            var brush = new BlueBrush();
            var triangle = new Triangle(brush);
            triangle.ShapeOperation();
        }
    }
}
