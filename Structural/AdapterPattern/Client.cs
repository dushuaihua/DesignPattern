namespace AdapterPattern
{
    public class Client
    {
        public void Connect()
        {
            ITarget target = new Adapter(new VGA());
            //target.ConnectWithDVI();
            target.ConnectWithHDMI();
        }
    }
}
