using PropertyPattern.Abstracts;

namespace PropertyPattern.Concretes
{
    [Serializable]
    public class ProtoTypeB : ProtoType
    {
        public override ProtoType Clone()
        {
            return MemberwiseClone() as ProtoType;
        }

        public override ProtoType DeepClone()
        {
            return this.DeepClone<ProtoType>();
        }
    }
}
