namespace FacadePattern.Subsystem
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }
}
