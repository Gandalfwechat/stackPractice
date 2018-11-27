using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QsortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataArray = new List<int>();
            Random rd = new Random();
            for (int i = 1; i < 200; i++)
            {               
                dataArray.Add(rd.Next(1,300));
            }
            var da = dataArray.ToArray();
            MyQsort(da, 0, dataArray.Count()-1);
        }


        public static void MyQsort(int[] DArray, int left, int right)
        {
            if (left>=right)
            {
                return;
            }
            int pivot = Partition(DArray, left,  right);

            MyQsort(DArray, left, pivot - 1);
            MyQsort(DArray, pivot + 1, right);

        }

        private static int Partition(int[] DArray,  int left, int right)
        {
            int pivot = left;
            var key = DArray[pivot];
            while (left < right)
            {
                while (right > pivot && DArray[right] >= key)
                {
                    right--;
                }
                DArray[pivot] = DArray[right];
                DArray[right] = key;
                pivot = right;
                while (left < pivot && DArray[left] <= key)
                {
                    left++;
                }
                DArray[pivot] = DArray[left];
                DArray[left] = key;
                pivot = left;
            }

            return pivot;
        }
    }

   




}
