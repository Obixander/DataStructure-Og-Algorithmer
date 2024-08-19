namespace Library
{
    public class TreeNode<T> where T : IComparable<T>
    {
        private TreeNode<T> parentNode;
        private TreeNode<T> leftNode;
        private TreeNode<T> rightNode;
        private T data;


        public TreeNode(T Data)
        {
            data = Data;
        }

        public TreeNode(TreeNode<T> parentNode, TreeNode<T> leftNode, TreeNode<T> rightNode, T data)
        {
            ParentNode = parentNode;
            LeftNode = leftNode;
            RightNode = rightNode;
            Data = data;
        }

        public TreeNode<T> ParentNode { get => parentNode; set => parentNode = value; }
        public TreeNode<T> LeftNode { get => leftNode; set => leftNode = value; }
        public TreeNode<T> RightNode { get => rightNode; set => rightNode = value; }
        public T Data { get => data; set => data = value; }

        public TreeNode<T> Insert(TreeNode<T> root, T value)
        {
            if (root == null)
            {
                return new TreeNode<T>(value);
            }

            if (value.CompareTo(root.Data) < 0)
            {
                root.LeftNode = Insert(root.LeftNode, value);
            }
            else if (value.CompareTo(root.Data) > 0)
            {
                root.RightNode = Insert(root.RightNode, value);
            }

            return root;
        }



    }
}
