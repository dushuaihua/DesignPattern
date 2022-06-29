using FacadePattern.Subsystem;

namespace FacadePattern.Facade
{
    public class ShapeFacade : IShapeFacade
    {
        private IShape _circle;
        private IShape _square;
        private IShape _rectrangle;

        public ShapeFacade()
        {
            _circle = new Circle();
            _square = new Square();
            _rectrangle = new Rectangle();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectrangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }
    }
}
