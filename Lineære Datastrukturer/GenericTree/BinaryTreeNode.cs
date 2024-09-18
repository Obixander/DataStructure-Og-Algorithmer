using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        private BinaryTreeNode<T> leftChild;
        private BinaryTreeNode<T> rightChild;

        public BinaryTreeNode()
        {
            
        }
        public BinaryTreeNode(T item)
        {
            this.Item = item;    
        }

        public BinaryTreeNode<T> LeftChild { get => leftChild; set => leftChild = value; }
        public BinaryTreeNode<T> RightChild { get => rightChild; set => rightChild = value; }

        public void AddLeftChild(T leftChild)
        {
            this.LeftChild.Item = leftChild;
            this.LeftChild.Parent = this; //maybe this works idk
        }
        public void AddRightChild(T rightChild)
        {
            this.RightChild.Item = rightChild;
            this.RightChild.Parent = this;
        }

    }
}
