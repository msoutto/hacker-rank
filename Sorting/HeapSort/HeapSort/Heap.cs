using System;
using System.Collections.Generic;
using System.Text;

namespace HeapSort
{
    public abstract class Heap
    {
        public List<int> Items { get; set; }

        public abstract void HeapifyUp();

        public abstract void HeapifyDown();

        public void Add(int item)
        {
            Items.Add(item);

            HeapifyUp();
        }

        public int Poll()
        {
            int item = Peek();
            Items[0] = Items[Length() - 1];
            Items.RemoveAt(Length() - 1);

            HeapifyDown();

            return item;
        }

        public int Peek()
        {
            if (Length() == 0)
                throw new InvalidOperationException();

            return Items[0];
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            int temp = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = temp;
        }

        public int LefChild(int index)
        {
            return Items[GetLeftChildIndex(index)];
        }
        public int RightChild(int index)
        {
            return Items[GetRightChildIndex(index)];
        }
        public int Parent(int index)
        {
            return Items[GetParentIndex(index)];
        }

        public bool HasLeftChild(int parentIndex)
        {// If the equation returns a value less then the length, then that index is populated
            return GetLeftChildIndex(parentIndex) < Length();
        }
        public bool HasRightChild(int parentIndex)
        {// If the equation returns a value less then the length, then that index is populated
            return GetRightChildIndex(parentIndex) < Length();
        }
        public bool HasParent(int childIndex)
        {// If the equation returns a value greater than or equal to 0,
         // then that index is a valid parentIndex and it is populated
            return GetParentIndex(childIndex) >= 0;
        }

        public int Length()
        {
            return Items.Count;
        }

        public int GetLeftChildIndex(int parentIndex)
        {
            return parentIndex * 2 + 1;
        }

        public int GetRightChildIndex(int parentIndex)
        {
            return parentIndex * 2 + 2;
        }

        public int GetParentIndex(int childIndex)
        {
            if (childIndex > 0)
                return (childIndex - 1) / 2;
            else
                return -1;
        }
    }
}
