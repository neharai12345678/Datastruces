using System;
using System.Collections.Generic;

namespace Tree
{
    public class BinaryTree
    {
        Node root = null;
        List<int> inorderBTreeTraversal = new List<int>();
        public Node CreatBST(int[] keys)
        {

            for (int i = 0; i < keys.Length; i++)
            {
                 root= BinarySerachTree.Insert(root, keys[i]);
                 
            }
            return root;
        }
       public void InorderTraversal(Node root)
        {
            if (root.leftNode != null)
            {
                InorderTraversal(root.leftNode);
            }
            inorderBTreeTraversal.Add(root.key);
            Console.Write(root.key.ToString());

            if (root.rightNode != null)
            {
                InorderTraversal(root.rightNode);
            }
        }
        public bool IsBST(Node node)
        {
            if (node==null)
            {
                return true;
            }

            if ((node.leftNode!=null && (node.key < node.leftNode.key ))||(node.rightNode != null && (node.key > node.rightNode.key)))
            {
                return false;
            }
            return IsBST(node.leftNode)
                       && IsBST(node.rightNode);
        }
    }
    public class Node
    {
        public Node leftNode;
        public Node rightNode;
        public int key;

        public Node(int key)
        {
            this.leftNode = null;
            this.rightNode = null;
            this.key = key;
        }
    }
    public class BinarySerachTree
    {
      public static Node Insert(Node rootNode, int key)
        {
            if (rootNode == null)
            {
                rootNode = new Node(key);

            }
            else if (key < rootNode.key)
            {
                rootNode.leftNode= Insert(rootNode.leftNode, key);
            }
            else
            {
                rootNode.rightNode = Insert(rootNode.rightNode, key);
            }
           
            return rootNode;
        }
    }
}
