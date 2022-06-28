namespace DecoratorPattern
{
    public abstract class WatchDecorator : IWatch
    {
        private readonly IWatch _watch;

        protected WatchDecorator(IWatch watch) => _watch = watch;

        public virtual void MakeWatch()
        {
            _watch.MakeWatch();
        }
    }
}
