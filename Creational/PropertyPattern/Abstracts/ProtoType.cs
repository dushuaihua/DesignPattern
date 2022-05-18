namespace PropertyPattern.Abstracts
{
    [Serializable]
    public abstract class ProtoType
    {
        public abstract ProtoType Clone();
        public abstract ProtoType DeepClone();
    }
}
