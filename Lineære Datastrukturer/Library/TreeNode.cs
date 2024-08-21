using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.GFG;

namespace Library
{
    public class TreeNode
    {
        private int key;
        private TreeNode left;
        private TreeNode right;

        public TreeNode(int key)
        {
            Key = key;
            Left = null;
            Right = null;
        }

        public int Key { get => key; set => key = value; }
        public TreeNode Left { get => left; set => left = value; }
        public TreeNode Right { get => right; set => right = value; }

        //Methods
        
        public static TreeNode Insert(TreeNode root, int key)
        {
            if (root == null)
            {
                root = new TreeNode(key);
                return root;
            }

            if (key < root.Key)
            {
                root.Left = Insert(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = Insert(root.Right, key);
            }
            return root;
        }

        // A function to do  
        // inorder traversal of BST 
        public static void inorderRec(TreeNode root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.Write(root.key + " ");
                inorderRec(root.right);
            }
        }

    }
}
