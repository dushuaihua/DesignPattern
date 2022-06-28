namespace DecoratorPattern
{
    public class DateWatchDecorator : WatchDecorator
    {
        public DateWatchDecorator(IWatch watch) : base(watch)
        {
        }

        public override void MakeWatch()
        {
            base.MakeWatch();
            AddDateFunction();
        }

        private void AddDateFunction()
        {
            Console.WriteLine("Add the date function to the watch.");
        }
    }
}
