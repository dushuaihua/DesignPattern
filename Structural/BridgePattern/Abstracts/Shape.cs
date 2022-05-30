namespace BridgePattern.Abstracts
{
    public abstract class Shape
    {
        private Brush _brush;

        public Shape(Brush brush)
        {
            _brush = brush;
        }
        public Brush Brush { get => _brush; set => _brush = value; }

        public abstract void ShapeOperation();
    }
}
