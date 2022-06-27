namespace CompositePattern
{
    public interface IComponent
    {
        void Add(IComponent component);
        void Remove(IComponent component);
        void Process(int indent);
    }
}