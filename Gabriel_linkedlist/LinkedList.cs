using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_linkedlist
{
    class LinkedList
    {
        private Node Head;

        public void addNode (string data)
        {
            // create a new node, assign string to node data
            Node NewNode = new Node(data);
            NewNode.Data = data;
            // assign null to next node
            NewNode.Next = null;
            //check to see if head is empty
            if (Head == null) Head = NewNode;
            //add new node to end of list
            else
            {
                // make a temp node
                Node temp = new Node(data);
                temp = Head;
                // while temp.next is not null temp = temp.next
                while (temp.Next !=null)
                {
                    temp = temp.Next;
                }
                //assign newNode to temp.next
                temp.Next = NewNode;
            }
            //NewNode.Next = Head;
            //Head = NewNode;
            //^^^^^^^ This adds to front of list
        }
        public void print()
        {          
            Node current = Head;
            // go through list and print until list is empty
            while (current != null)
            {
                Console.WriteLine(current.Data);              
                current = current.Next;              
            }
        }
        public string SearchNode(string searchNode)
        {                       
            Node current = Head;
            //go through list and search for data string entered and return found Node
            // if not found return search string not found
            while (current != null)
            {
                if (current.Data == searchNode)
                {
                    return "Found " + current.Data;
                }
                if (current.Data != searchNode)
                {
                    current = current.Next;                  
                }
                return searchNode + " Not found";
            }
            return null;
        }
        public void DeleteNode (string deleteNode)
        {
            // if head is null return, if head data = delete string change head to the next node
            if (Head == null) return;
            if (Head.Data == deleteNode)
            {
                Head = Head.Next;
                return;
            }
            // loop through list until string matches data, then reset head
            Node current = Head;
            while (current.Next.Data == deleteNode)
            {
                if (current.Next.Data == deleteNode)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
    }
}

