using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    class BinarySearchTree<T>
    {
        public TreeNode<T> Root { get; set; }
        //Constructor and methods to set binarytree            
        public BinarySearchTree()                                   
        {
            this.Root = null;
        }
        public void Insert(T x)                    
        {
            this.Root = Insert(x, this.Root);
        }
        public void Remove(T x)
        {
            this.Root = Remove(x, this.Root);
        }
        public void RemoveMin()
        {
            this.Root = RemoveMin(this.Root);
        }
        public T FindMin()
        {
            return ElementAt(FindMin(this.Root));
        }
        public T FindMax()
        {
            return ElementAt(FindMax(this.Root));
        }
        public T Find(T x)
        {
            return ElementAt(Find(x, this.Root));
        }
        public void MakeEmpty()
        {
            this.Root = null;
        }
        public bool IsEmpty()
        {
            return this.Root == null;
        }
        private T ElementAt(TreeNode<T> t)
        {
            return t == null ? default(T) : t.Element;
        }

        //Searchs for number x in Tree t , compares number x with element of t , if x is smaller or greater than t.element
        private TreeNode<T> Find(T x, TreeNode<T> t)                
        {
            while (t != null)
            {
                if ((x as IComparable).CompareTo(t.Element) < 0)    
                {
                    t = t.Left;
                }
                else if ((x as IComparable).CompareTo(t.Element) > 0)   
                {
                    t = t.Right;
                }
                else
                {
                    return t;
                }
            }
            return null;
        }

        // Finds the min number in Tree t, while having values on the left side of the current tree or branch , it goes left(to the smallest number)
        private TreeNode<T> FindMin(TreeNode<T> t)                  
        {
            if (t != null)                                         
            {
                while (t.Left != null)                              
                {
                    t = t.Left;
                }
            }
            return t;
        }

        // Finds the max number in Tree t, while having values on the right side of the current tree or branch , it goes right(to the greatest number)
        private TreeNode<T> FindMax(TreeNode<T> t)             
        {
            if (t != null)                                     
            {
                while (t.Right != null)                           
                {
                    t = t.Right;
                }
            }
            return t;
        }
        protected TreeNode<T> Insert(T x, TreeNode<T> t)        
        {
            if (t == null)
            {
                t = new TreeNode<T>(x);
            }
            else if ((x as IComparable).CompareTo(t.Element) < 0)
            {
                t.Left = Insert(x, t.Left);
            }
            else if ((x as IComparable).CompareTo(t.Element) > 0)
            {
                t.Right = Insert(x, t.Right);
            }
            else
            {
                //Changed exception to MessageBox
                MessageBox.Show("Duplicate item");       
            }
            return t;
        }
        protected TreeNode<T> RemoveMin(TreeNode<T> t)
        {
            if (t == null)
            {
                //Changed exception to MessageBox
                MessageBox.Show("Item not found");       
                return null;
            }
            else if (t.Left != null)
            {
                t.Left = RemoveMin(t.Left);
                return t;
            }
            else
            {
                return t.Right;
            }
        }
        protected TreeNode<T> Remove(T x, TreeNode<T> t)
        {
            if (t == null)
            {
                //Changed exception to MessageBox
                MessageBox.Show("Item not found");              
            }
            else if ((x as IComparable).CompareTo(t.Element) < 0)
            {
                t.Left = Remove(x, t.Left);
            }
            else if ((x as IComparable).CompareTo(t.Element) > 0)
            {
                t.Right = Remove(x, t.Right);
            }
            else if (t.Left != null && t.Right != null)
            {
                t.Element = FindMin(t.Right).Element;
                t.Right = RemoveMin(t.Right);
            }
            else
            {
                t = (t.Left != null) ? t.Left : t.Right;
            }
            return t;
        }
        public override string ToString()
        {
            return this.Root.ToString();
        }
    }
}

