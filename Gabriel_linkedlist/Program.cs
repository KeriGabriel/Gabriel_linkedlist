using System;

namespace Gabriel_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Head = new Node(null);            
            Node CurrentNode = Head;
            LinkedList list = new LinkedList();
            string choice;
            while (true)
            {
                printMenu();
                if (choice == "1")
                {
                    Console.WriteLine(" Add Item ");
                    string newNodeData = Console.ReadLine();
                    list.addNode(newNodeData);
                    Console.WriteLine(newNodeData + " Added");
                    Console.WriteLine("");
                }
                if (choice == "2")
                {
                    Console.WriteLine(" Remove Item ");
                    string deleteNode = Console.ReadLine();
                    list.DeleteNode(deleteNode);
                    Console.WriteLine(deleteNode + " Removed");
                    Console.WriteLine("");
                }
                if (choice == "3")
                {
                    Console.WriteLine(" Search for Item ");
                    string searchNode = Console.ReadLine();                    
                    Console.WriteLine(list.SearchNode(searchNode));
                    Console.WriteLine("");
                }
                if (choice =="4")
                {
                    Console.WriteLine("Printing List " );
                    list.print();
                    Console.WriteLine("");
                }
                if (choice =="5")
                {
                    Console.WriteLine(" Exit ");
                    break;
                }               
            }
            void printMenu()
            {
                Console.WriteLine("Main Menu ");
                Console.WriteLine("1. Add Item ");
                Console.WriteLine("2. Remove Item ");
                Console.WriteLine("3. Search for Item ");
                Console.WriteLine("4. Print ");
                Console.WriteLine("5. Exit ");
                choice = Console.ReadLine();
                Console.WriteLine("");
            }          
        }
    }
    
}
