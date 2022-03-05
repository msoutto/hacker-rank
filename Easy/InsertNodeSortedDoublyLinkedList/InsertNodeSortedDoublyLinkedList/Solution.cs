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

    class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    static void PrintDoublyLinkedList(DoublyLinkedListNode node)
    {
        while (node != null)
        {
            Console.WriteLine(node.data);

            node = node.next;
        }
    }


    /*
     * Complete the 'sortedInsert' function below.
     *
     * The function is expected to return an INTEGER_DOUBLY_LINKED_LIST.
     * The function accepts following parameters:
     *  1. INTEGER_DOUBLY_LINKED_LIST llist
     *  2. INTEGER data
     */

    /*
     * For your reference:
     *
     * DoublyLinkedListNode
     * {
     *     int data;
     *     DoublyLinkedListNode next;
     *     DoublyLinkedListNode prev;
     * }
     *
     */

    static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data)
    {
        if (llist == null)
            return new DoublyLinkedListNode(data);
        
        DoublyLinkedListNode current = llist;

        if (data < current.data)
        {
            insertBefore(current, new DoublyLinkedListNode(data));
            return current.prev;
        }

        while (current.next != null)
        {
            if (current.next.data > data)
            {
                insertAfter(current, new DoublyLinkedListNode(data));
                break;
            }

            current = current.next;
        }

        // Iterated through whole list, insert data to the tail
        if (current.next == null)
            insertAfter(current, new DoublyLinkedListNode(data));

        /*
        // Right place to insert data
        if (current.data > data)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(data);

            // Is it in the middle of the list? 
            if (current.prev != null)
            {
                node.prev = current.prev;
                current.prev.next = node;
            }
            else
            {// current was the head node, so now the new node is the head
                llist = node;
            }

            current.prev = node;
            node.next = current;
        }
        else
        {
            sortedInsert(current.next, data);
        }
        */
        return llist;
    }

    static void insertAfter(DoublyLinkedListNode current, DoublyLinkedListNode node)
    {
        node.next = current.next;
        node.prev = current;
        current.next = node;
    }

    static void insertBefore(DoublyLinkedListNode current, DoublyLinkedListNode node)
    {
        node.next = current;
        node.prev = current.prev;
        current.prev.next = node;
        current.prev = node;
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            DoublyLinkedList llist = new DoublyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);

            PrintDoublyLinkedList(llist1);
        }
    }
}
