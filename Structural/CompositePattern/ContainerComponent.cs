namespace CompositePattern
{
    public class ContainerComponent : IComponent
    {
        private readonly List<IComponent> components = new();

        public IReadOnlyList<IComponent> Components { get { return components; } }

        private readonly string _name;

        public ContainerComponent(string name)
        {
            _name = name;
        }
        public void Add(IComponent component)
        {
            components.Add(component);
        }
        public void Remove(IComponent component)
        {
            component.Remove(component);
        }
        public void Process(int indent)
        {
            Console.WriteLine($"{new string('-', indent)}+ {_name}");

            foreach (var item in components)
            {
                item.Process(indent + 3);
            }
        }
    }
}
