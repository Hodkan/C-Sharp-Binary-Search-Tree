using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Ali Albayrak - P304320 - 18/08/2017 - Binary Search Tree - AT 1.2
/*In the previous activities you created several Binary Trees; in this assessment activity you will
implement a Binary Search Tree (BST) and develop a fully functional User Interface. Your UI must
demonstrate all the method calls in the BinarySearchTree class.
Use the code supplied below to create a Windows Forms application, and add sufficient components
to demonstrate all the methods in the BinarySearchTree class. Ensure you have the following:
 Button methods for:
o To fill the tree with 10 nodes.
o Insert
o Remove
o RemoveMin
o FindMin
o FindMax
o Find
o MakeEmpty
o IsEmpty
o Trace
o Display
 Test your code to ensure ALL code paths are traversed (Screen Shots)
 Your test document will show the code under test and a screen shot of the results.
 Add comments to all the code at each method and major statement (not XML)*/

namespace BinarySearchTree
{
    class TreeNode<T>
    {
        public T Element { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode(T element)
        {
            this.Element = element;
        }
        public override string ToString()
        {
            
            string nodeString = "[ " + this.Element + " ";
            // Leaf node
            if (this.Left == null && this.Right == null)
            {
                nodeString += " (Leaf) ";
            }
            if (this.Left != null)
            {
                nodeString += "L: " + this.Left.ToString();
            }
            if (this.Right != null)
            {
                nodeString += "R: " + this.Right.ToString();
            }
            nodeString += "] ";
            return nodeString;

        }
    }
}
