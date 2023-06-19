using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public T Nodedata { get; set; }
        public BinaryTree<T> LeftTree { get; set; }
        public BinaryTree<T> RightTree { get; set; }
        public BinaryTree(T nodedata)
        {
            this.Nodedata = nodedata;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.Nodedata;
            if (currentNodeValue.CompareTo(item) > 0)
            {

                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinaryTree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinaryTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Nodedata.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
