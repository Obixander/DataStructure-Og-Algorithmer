using System.Reflection.Metadata;

namespace GenericTree
{
    public interface INonLinearDataStructure<T>
    {
        public int Count { get; set; }
    }
}
