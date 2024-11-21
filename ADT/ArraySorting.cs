using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.ADT
{
    public class ArraySorting
    {

        /*
         * quadratic O(n^2)
         */
        public static int[] BubleSort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1 ; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if(array[j + 1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        /*
         *  optimized bubble sort has a time complexity of (O(n)) in the best case 
         *  and (O(n^2)) in the average and worst cases, 
         *  with a space complexity of (O(1))
         */
        public static int[] EnhancedBubleSort(int[] array)
        {
            int length = array.Length;
            bool swaped = false;
            for(int i = 0; i < length - 1; i++)
            {
                swaped = false;
                for (int j = 0;j < length - i - 1; j++)
                {
                    if (array[j+1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        swaped = true;
                    }
                }
                if (!swaped)
                {
                    break;
                }
            }
            return array;
        }

        /*
         *  quadratic O(n^2)
         */
        public static int[] SelectionSort(int[] array)
        {
            int smallest;
            int length = array.Length;

            for(int i = 0;i < length; i++)
            {
                smallest = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                if(i != smallest) { 
                    int tmp = array[smallest];
                    array[smallest] = array[i];
                    array[i] = tmp;
                }
            }
            return array;
        }

        
    }
}
