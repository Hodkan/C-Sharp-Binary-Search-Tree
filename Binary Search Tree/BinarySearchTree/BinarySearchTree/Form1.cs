using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Form1 : Form
    {
        // Creating Binarytree
        BinarySearchTree<int> intTree = new BinarySearchTree<int>();                        
        string trace = "";
        int randomInt,b;
        public Form1()
        {
            InitializeComponent();         
        }

        // Inserting 10 random integers into the tree on button click
        private void buttonGenerate_Click(object sender, EventArgs e)                      
        {
            Random r = new Random(DateTime.Now.Millisecond);
            intTree.MakeEmpty();
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                randomInt = r.Next(1, 500);
                intTree.Insert(randomInt);
                trace += randomInt + " ";               
                int x = intTree.Root.Element;
                textBoxRoot.Text = Convert.ToString(x);
            }

            listBox1.Items.Add(intTree.ToString());

        }

        //Inserting a number(taken from user via textBoxInput) into binary tree
        private void buttonInsert_Click(object sender, EventArgs e)             
        {
            if (textBoxInput != null)
            {
                try
                {
                    int a = Convert.ToInt32(textBoxInput.Text);
                    intTree.Insert(a);
                    listBox1.Items.Add(intTree.ToString());
                    int x = intTree.Root.Element;
                    textBoxRoot.Text = Convert.ToString(x);
                    textBoxInput.Clear();
                    trace += a + " ";
                }
                catch
                {
                   textBoxInput.Clear();
                    MessageBox.Show("Please enter a number");
                }               
            }
            else
            {
                MessageBox.Show("Please enter a number to insert");
            }
        }

        // Deletes the number(taken from user via textBoxInput) from the tree
        private void buttonRemove_Click(object sender, EventArgs e)             
        {
            try
            {
                intTree.Remove(Convert.ToInt32(textBoxInput.Text));
                listBox1.Items.Add(intTree.ToString());
                int x = intTree.Root.Element;
                textBoxRoot.Text = Convert.ToString(x);
                textBoxInput.Clear();
            }
            catch
            {
                textBoxInput.Clear();
                MessageBox.Show("Please enter a number");
            }
        }

        //Deletes the min number in the tree and displays the current tree into listbox
        private void buttonMin_Click(object sender, EventArgs e)           
        {
            intTree.RemoveMin();
            listBox1.Items.Add(intTree.ToString());
        }

        // Finds the minumum number in the tree and displays it in the textBoxFind
        private void buttonFindMin_Click(object sender, EventArgs e)            
        {
           textBoxFind.Text = Convert.ToString(intTree.FindMin());
        }

        // Finds the max number in the tree and displays it in the textBoxFind
        private void buttonFindMax_Click(object sender, EventArgs e)            
        {
            textBoxFind.Text = Convert.ToString(intTree.FindMax());
        }

        // Searchs for the number(taken from user via textBoxFind) in the tree and displays message according to result
        private void buttonFind_Click(object sender, EventArgs e)              
        {
            try
            {
                b = intTree.Find(Convert.ToInt32(textBoxFind.Text));
                if (b == Convert.ToInt32(textBoxFind.Text))
                {
                    MessageBox.Show("YES! Number found in BinaryTree");
                }
                else
                {
                    MessageBox.Show("NO! Number does not exist in BinaryTree");
                }
            }

            catch
            {
                textBoxFind.Clear();
                MessageBox.Show("Please enter a number");
            }
        }

        // Clears the Tree and listbox
        private void buttonMakeEmpty_Click(object sender, EventArgs e)          
        {
            intTree.MakeEmpty();
            listBox1.Items.Clear();
        }

        // Checks if tree is empty or not and display result in textBoxEmpty
        private void buttonIsEmpty_Click(object sender, EventArgs e)            
        {
            textBoxEmpty.Text = Convert.ToString(intTree.IsEmpty());
        }


        // Keeps the trace of numbers in the tree even if they are deleted in a single session
        private void buttonTrace_Click(object sender, EventArgs e)          
        {
            textBoxTrace.Clear();
            textBoxTrace.Text = trace;        
        }
    }
}
