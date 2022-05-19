namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        private readonly VGA _vga;

        public Adapter(VGA vga)
        {
            _vga = vga;
        }

        public void ConnectWithDVI()
        {
            _vga.ConnectWithVGA();
            Console.WriteLine("Connect to GPU with DVI interface.");
        }

        public void ConnectWithHDMI()
        {
            _vga.ConnectWithVGA();
            Console.WriteLine("Connect to GPU with HDMI interface.");
        }
    }
}
