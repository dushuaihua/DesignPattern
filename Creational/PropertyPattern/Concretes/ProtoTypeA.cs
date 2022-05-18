using PropertyPattern.Abstracts;

namespace PropertyPattern.Concretes
{
    [Serializable]
    public class ProtoTypeA : ProtoType
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