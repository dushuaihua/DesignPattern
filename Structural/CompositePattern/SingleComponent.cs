namespace CompositePattern
{
    public class SingleComponent : IComponent
    {
        private readonly string _name;

        public SingleComponent(string name)
        {
            _name = name;
        }

        public void Add(IComponent component)
        {
            throw new NotSupportedException();
        }
        public void Remove(IComponent component)
        {
            throw new NotSupportedException();
        }

        public void Process(int indent)
        {
            Console.WriteLine($"{new string('-', indent)} {_name}");
        }
    }
}
