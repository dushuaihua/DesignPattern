using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern
{
    public class Runner
    {
        IPeripheralFactory _peripheralFactory;

        public Runner(IPeripheralFactory peripheralFactory)
        {
            _peripheralFactory = peripheralFactory;
        }

        Mouse Mouse;
        Keyboard Keyboard;

        public void BuildPeripheral()
        {
            Console.WriteLine("Build peripherals...");
            Mouse = _peripheralFactory.CreateMouse();
            Keyboard = _peripheralFactory.CreateKeyboard();
        }

        public void UsePeripheral()
        {
            Console.WriteLine("Use peripherals...");
            Mouse.Click();
            Keyboard.Input();
            Mouse.Move();
        }

    }
}
