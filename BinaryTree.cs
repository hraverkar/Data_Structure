using System;
/*Some data you want ti store in hierarchy form.- Example file system 
 * Provide less time for search and sorting.
 * porvide less time for insertion and deletion
 * 
 * 
 * Binary Tree : A tree whose lelement have atleast at the most 2 children.
 * typically thats called left and right child.
 * 
 * 
 * Mostly teo part -- >
 * Data 
 * Left Child
 * Right Child
 */
namespace ConsoleApp62
{
  class Node
  {
    int data;
    public Node right, left;

    public Node(int data)
    {
      this.data = data;
      right = null;
      left = null;
    }
  }
  public class BinaryTree
  {
    Node root;

    public BinaryTree(int key)
    {
      root = new Node(key);
    }

    BinaryTree()
    {
      root = null;
    }

    public static void Main()
    {
      BinaryTree bt = new BinaryTree();
      bt.root = new Node(1);
      bt.root.left = new Node(2);
      bt.root.right = new Node(3);
      bt.root.left.left = new Node(4);
      bt.root.left.right = new Node(5);
      bt.root.right.left = new Node(6);
      bt.root.right.right = new Node(7);
    }
  }
}
