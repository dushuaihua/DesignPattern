using PropertyPattern.Abstracts;

namespace PropertyPattern
{
    public class Client
    {
        public void BuildClient(ProtoType protoType)
        {
            Console.WriteLine(protoType.Clone());
            Console.WriteLine(protoType.DeepClone());
        }
    }
}