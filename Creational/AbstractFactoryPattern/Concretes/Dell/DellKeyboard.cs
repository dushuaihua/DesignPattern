namespace AbstractFactoryPattern.Concretes;

public class DellKeyboard : Keyboard
{
    public DellKeyboard()
    {
        Console.WriteLine("Dell keyboard init...");
    }
    public override void Input()
    {
        Console.WriteLine("Dell keyboard input");
    }
}
