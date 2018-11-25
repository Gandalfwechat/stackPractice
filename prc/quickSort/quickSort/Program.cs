using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayData  = new  int[] {6,3,1,4,2,5,9};

            var pivot = partition(0, 6, arrayData);

            quickSortMethod(arrayData);

        }

        public static void quickSortMethod(int[] array)
        {
            if (array.Count() > 1)
            {
                var pivot = partition(0, array.Count() - 1, array);
                var subArray2 = array.Skip(pivot + 1).ToArray();
                var subArray1 = array.Take(pivot).ToArray();

                quickSortMethod(subArray1);
                quickSortMethod(subArray2);
            }
            else
            {
                return; 
            }

        }


        public static int partition(int left, int right, int[] array)
        {
            int pivot = left;
            while (right > left)
            {
                while (right>pivot)
                {
                    if (array[right]<array[pivot])
                    {                                     
                        var a = array[pivot];
                        array[pivot] = array[right];
                        array[right] = a;
                        pivot = right;

                        break;
                    }
                    right--;
                }

                while (left<pivot)
                {
                    if (array[pivot] < array[left])
                    {
                        var a = array[pivot];
                        array[pivot] = array[left];
                        array[left] = a;

                        pivot = left;

                        break;
                    }
                    left++;
                }

            }
            return pivot; 
        }

        public static void Swap(int a, int b)
        {
            var temp = a;
            a = b;
            b = temp;

        }



    }
}
