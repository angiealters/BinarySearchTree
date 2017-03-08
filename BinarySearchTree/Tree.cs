using System.Collections.ObjectModel;

namespace BinarySearchTree
{
    public class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }
        public Tree (int initial)
        {
            top = new Node(initial);
        }
        public void AddNode(int value)
        {
            Node currentNode = top;
            bool added = false;

            if (top == null)
            {
                Node newNode = new Node(value);
                top = newNode;
                return;
            }
            do
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
            while (!added);
        }

    }
}