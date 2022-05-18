using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System
{
    public static class ObjectExtensions
    {
        public static T DeepClone<T>(this object obj)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new InvalidOperationException();
            }
            if (obj == null)
            {
                return default;
            }
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
