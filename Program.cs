using DataStructure.ADT;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test fibunacci algorithm
            //Console.WriteLine(fibunacci(19));

            //search for the lowesr element in array
            int[] myArray = new int[] { 1, 2, 3,5,7,0,10,11,20,5,7,-20 };
            //Console.WriteLine(lowestElemntInArray(myArray));
            Console.WriteLine($"[{String.Join(", ",myArray)}]");
            //Console.WriteLine($"[{String.Join(", ",ArraySorting.EnhancedBubleSort(myArray))}]");
            Console.WriteLine($"[{String.Join(", ", ArraySorting.SelectionSort(myArray))}]");

        }


        /*
         * example of implementing fibunacci algorithm
         * using recursion
         * time complexty O(log(n))
         */
        static int fibunacci(int number)
        {

            return number <= 1 ? number:fibunacci(number - 1) + fibunacci(number - 2);
        }


        /*
         * retrieve the lowest element algorithm
         * time complexty Linear O(n)
         */
        static int lowestElemntInArray(int[] arr)
        {
            int minVal = int.MaxValue;
            foreach (int i in arr)
            {
                if (i < minVal)
                {
                    minVal = i;
                }
            }
            return minVal;
        }
    }
}
