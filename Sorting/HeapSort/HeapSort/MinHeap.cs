using System;
using System.Collections.Generic;
using System.Text;

namespace HeapSort
{
    public class MinHeap : Heap
    {
        public MinHeap(List<int> items = null)
        {
            if (items == null)
                Items = new List<int>();
            else
                Items = items;
        }

        public override void HeapifyUp()
        {// Gets the last index (last item added)
            int index = Length() - 1;

            while (HasParent(index) && Parent(index) > Items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        public override void HeapifyDown()
        {
            int index = 0;

            // If it does not have a left child, then it does not have right child either...
            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);

                if (HasRightChild(index) && RightChild(index) < Items[smallerChildIndex])
                    smallerChildIndex = GetRightChildIndex(index);

                //Already sorted?
                if (Items[index] < Items[smallerChildIndex])
                    break;

                Swap(index, smallerChildIndex);
                index = smallerChildIndex;
            }
        }
    }
}
