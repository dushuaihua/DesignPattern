namespace BridgePattern.Concretes.Brushes
{
    public class RedBrush : Brush
    {
        public override void DrawShape()
        {
            Console.WriteLine("Start drawing with red brush...");
        }
    }
}
