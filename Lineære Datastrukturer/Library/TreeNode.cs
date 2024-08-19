using System.Xml.Linq;

namespace Library
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public int key;
        public TreeNode<T> left, right;

        public TreeNode(int item)
        {
            key = item;
            left = right = null;
        }
    }
}
