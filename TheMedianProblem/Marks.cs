using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMedianProblem
{
    internal class Marks
    {
        private int[] list;
        private int[] sortedList;
        private int numElements;

        public int[] List
        {
            get { return list; }
        }

        public int[] SortedList
        {
            get { return sortedList; }
        }

        public int NumElements
        {
            get { return numElements; }
        }
        

        public Marks(int size)
        {
            list = new int[size];
            sortedList = new int[size];
            numElements = 0;
        }
        public void Insert(int item)
        {
            numElements++;
            list[numElements] = item;
        }      

        public void ShellSort()
        {
            //Copy the array, so we don't lose the original data.
            Array.Copy(list, sortedList, sortedList.Length);

            //Set the gap initailly to the number of elements.
            int gap = numElements;

            int max, iPlusGap, swap, temp;

            do
            {
                //Each itteration reduce the gap.
                gap = gap / 2;

                max = numElements - gap;

                do
                {
                    //Count the swaps.
                    swap = 0;

                    for (int i = 1; i <= max; i++)
                    {
                        //Example:
                        //If there are 14 elements,
                        //checks 1st element with the 8th,
                        //then 2nd with the 9th,
                        //3rd with the 10th and so on...
                        //If they are not in the right order, we swap them.
                        //Repeat this until no swaps were made, then go back at the outer loop.
                        //Eventually we reach where the gap is none, so then we check all elements and stop when no swaps were made.
                        iPlusGap = i + gap;
                        if (sortedList[i] > sortedList[iPlusGap])
                        {
                            temp = sortedList[i];
                            sortedList[i] = sortedList[iPlusGap];
                            sortedList[iPlusGap] = temp;

                            swap++;
                        }
                    }
                }
                while (swap != 0);
            }
            while (gap >= 1);
        }

        public double FindMedian()
        {
            int median;

            if (numElements % 2 == 0)
            {
                median = (sortedList[numElements / 2] + sortedList[(numElements + 2) / 2]) / 2;
            }
            else
            {
                median = sortedList[(numElements + 1) / 2];
            }

            return median;
        }
    }
}
