using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public interface IBinaryTree<T> : INonLinearDataStructure<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int GetHeight(BinaryTreeNode<T> root);
        public string ToStringLevel(int level, BinaryTreeNode<T> Root);
        public int ToStringLevelOrder();
        public void AddLeftChildTo(BinaryTreeNode<T> Parent, T leftChildItem);
        public void AddRightChildTo(BinaryTreeNode<T> Parent, T rightChildItem);

    }
}
