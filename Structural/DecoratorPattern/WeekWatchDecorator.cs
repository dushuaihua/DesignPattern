namespace DecoratorPattern
{
    public class WeekWatchDecorator : WatchDecorator
    {
        public WeekWatchDecorator(IWatch watch) : base(watch)
        {
        }

        public override void MakeWatch()
        {
            base.MakeWatch();
            AddWeekFunction();
        }

        private void AddWeekFunction()
        {
            Console.WriteLine("Add the week function to the watch.");
        }
    }
}
