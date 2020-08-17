using System;

class GfG
{

    class Node
    {
        public string data;
        public Node next;
    }

    // Deletes middle node and returns 
    // head of the modified list 
    static Node deleteMid(Node head)
    {
        // Base cases 
        if (head == null)
            return null;
        if (head.next == null)
        {
            return null;
        }

        // Initialize slow and fast pointers 
        // to reach middle of linked list 
        Node slow_ptr = head;
        Node fast_ptr = head;

        // Find the middle and previous of middle. 
        Node prev = null;

        // To store previous of slow_ptr 
        while (fast_ptr != null && fast_ptr.next != null)
        {
            fast_ptr = fast_ptr.next.next;
            prev = slow_ptr;
            slow_ptr = slow_ptr.next;
        }

        // Delete the middle node 
        prev.next = slow_ptr.next;

        return head;
    }

    static void printList(Node ptr)
    {
        while (ptr != null)
        {
            Console.Write(ptr.data + "->");
            ptr = ptr.next;
        }
        Console.WriteLine("NULL");
    }

    // Utility function to create a new node. 
    static Node newNode(string data)
    {
        Node temp = new Node();
        temp.data = data;
        temp.next = null;
        return temp;
    }

    public static void Main(String[] args)
    {
        /* Start with the empty list */
        Node head = newNode("a");
        head.next = newNode("b");
        head.next.next = newNode("c");
        head.next.next.next = newNode("d");
        head.next.next.next.next = newNode("e");


        Console.WriteLine("Gven Linked List");
        printList(head);

        head = deleteMid(head);

        Console.WriteLine("Linked List after"
                          + "deletion of middle");
        printList(head);

        Console.ReadLine();
    }
}

