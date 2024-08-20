using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class GFG //this feels like black magics ngl
    {
        public class Node // What the fuck
        {
            public int key;
            public Node left, right; //how does this work???

            public Node(int item)
            {
                key = item;
                left = right = null; //does this set right to be null and left to be right??
            }
        } //What the fuck

        public Node root; // not the best
        public GFG()
        {
            root = null;
        }

        private void Insert(int key) //What is key like an Id???
        {
            root = InsertRec(root, key); //root is the Parent node i think???
        }

        /* A recursive function to  
        insert a new key in BST */
        private Node InsertRec(Node root, int key)
        {

            /* If the tree is empty, 
                return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur 
                down the tree */
            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else if (key > root.key)
                root.right = InsertRec(root.right, key);

            /* return the root */
            return root;
        }

        // A function to do  
        // inorder traversal of BST 
        public void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.Write(root.key + " ");
                inorderRec(root.right);
            }
        }
        public void treeins(int[] arr) //Inserts an int[] into the tree
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Insert(arr[i]);
            }

        }

       


    }
}
