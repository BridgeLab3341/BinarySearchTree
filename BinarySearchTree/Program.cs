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
            binary.Insert(20);
            binary.Insert(40);
            binary.Insert(60);
            binary.Insert(95);
            binary.Insert(11);
            binary.Insert(3);
            binary.Insert(16);
            binary.Insert(65);
            binary.Insert(63);
            binary.Insert(67);
            binary.Display();
            binary.GetSize();
            bool result = binary.IfExits(63, binary);
            Console.WriteLine(result);
        }
    }
}
