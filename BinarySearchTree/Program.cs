namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree<int> binary = new BinaryTree<int>(56);
            // BinaryTree<int> binary1 = new BinaryTree<int>(30);
            // BinaryTree<int> binary2 = new BinaryTree<int>(70);
            binary.Insert(30);
            binary.Insert(70);
            binary.Display();
            binary.GetSize();
        }
    }
}
