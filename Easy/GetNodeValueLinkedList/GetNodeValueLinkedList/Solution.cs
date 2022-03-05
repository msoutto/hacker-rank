using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    /*
     * Complete the 'getNode' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_SINGLY_LINKED_LIST llist
     *  2. INTEGER positionFromTail
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */

    static int getNode(SinglyLinkedListNode llist, int positionFromTail)
    {
        llist = reverse(llist);
        // The current head was the tail, so start iterating from here
        return getNodeFromHead(llist, positionFromTail);
    }

    static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
    {
        // List is empty or single node, the reverse is the same
        if (llist == null || llist.next == null)
            return llist;

        // Keep the current tail node, which will be the new head node
        SinglyLinkedListNode newHead = reverse(llist.next);

        // Point the next node to the current
        llist.next.next = llist;

        // Point the current node to null
        // If it ends here it means that this was the head and now it is the tail
        llist.next = null;

        return newHead;
    }

    static int getNodeFromHead(SinglyLinkedListNode llist, int position)
    {
        // Negative position or position greater than the length are invalid situations
        if (position < 0 || llist == null)
            throw new ArgumentOutOfRangeException();
        else
        {// Params are valid
            // If we are at the right position, retrieve it
            if (position == 0)
                return llist.data;
            else
            {// We are not at the right position, keep looking for it
                return getNodeFromHead(llist.next, position - 1);
            }
        }
    }

    static void Main(string[] args)
    {
        int tests = Convert.ToInt32(Console.ReadLine());

        for (int testsItr = 0; testsItr < tests; testsItr++)
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int position = Convert.ToInt32(Console.ReadLine());

            int result = getNode(llist.head, position);

            Console.WriteLine(result);
        }
    }
}
