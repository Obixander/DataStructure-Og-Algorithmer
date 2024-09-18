using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        private BinaryTreeNode<T> root;
        public BinaryTree(BinaryTreeNode<T> root)
        {
            this.Root = root;
        }


        public int Count { get; set; }
        public BinaryTreeNode<T> Root { get => root; set => root = value; }

        public void AddLeftChildTo(BinaryTreeNode<T> Parent, T leftChildItem)
        {
            Parent.LeftChild.Item = leftChildItem;
            Parent.LeftChild.Parent = Parent;
        }

        public void AddRightChildTo(BinaryTreeNode<T> Parent, T rightChildItem)
        {
            Parent.RightChild.Item = rightChildItem;
            Parent.RightChild.Parent = Parent;
        }

        public int GetHeight(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                var leftHeight = GetHeight(Root.LeftChild);
                var rightHeight = GetHeight(Root.RightChild);
                if (leftHeight > rightHeight)
                {
                    return leftHeight + 1;
                }
                else
                {
                    return rightHeight + 1;
                }
            }
        }
        public int GetCount()
        {
            return Count;
        }

        public string ToStringLevel(int level, BinaryTreeNode<T> Root) // Makes no sense? what have i made????????
        {
            if (Root == null)
            {
                return "";
            }
            if (root.LeftChild != null)
                level++;
            if (root.RightChild != null)
                level++;
            return level.ToString(); //????
        }

        public int ToStringLevelOrder()
        {
            throw new NotImplementedException();
        }
    }
}
