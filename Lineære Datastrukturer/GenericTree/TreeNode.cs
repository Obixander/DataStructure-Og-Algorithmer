using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public class TreeNode<T> : Node<T>
    {
        private TreeNode<T> parent;
        public TreeNode()
        {
            
        }
        public TreeNode(T item) //used to make an root?
        {
            this.Item = item;
        }
        public TreeNode(T item, TreeNode<T> parent)
        {
            this.Item = item;
            this.parent = parent;
        }
        public TreeNode(TreeNode<T> parent)
        {
            this.parent = parent;
        }
            
        public TreeNode<T> Parent
        {
            get
            {
                return parent;
            } 
            set
            {
                parent = value;
            }
        }



    }
}
