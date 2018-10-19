using System;
using System.Collections.Generic;

namespace basic_13
{
    class Program
    {
        // //print 1-255
        public static void PrintNum()
        {
            for(int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        //print odd 1-255 
        public static void PrintOdd()
        {
            for(int i = 1; i < 256; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Print Sum 0-255
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i <= 255; i++)
            {
                sum += i; 
                Console.WriteLine($"New Number: {i} Sum: {sum}"); //string interpolation
            }
            
        }

        //print iterate through array
        public static void IterateArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        //find max
        public static void FindMax(int[] arr)
        {
            int max = arr[0]; //this initiates at index zero in case max is a negitive number
            foreach(int num in arr)
            {
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("The max number is {0}", max);
        }

        //find min
        public static void FindMin(int[] arr)
        {
            int min = arr[0];
            foreach(int num in arr)
            if(num < min)
            {
                min = num;
            }
            Console.WriteLine($"The Min number is {min}");
        }

        
        public static void FindAvg(int[] arr)
        {
            int sum = GetSum(arr);
            Console.WriteLine("The average is: " + (double)sum/(double)arr.Length);
        }
        public static int GetSum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += i; 
            }
            return sum;
        }

        //create array of odd numbers betwen 1 - 255
        public static int[] CreateOddArray()
        {
            List<int> OddList = new List<int>();
            for(int i = 0; i < 256; i++)
            {
                if(i % 2 != 0)
                {
                    OddList.Add(i);
                }
            }
            return OddList.ToArray();
        }

        //count all values greater than Y
        public static void GreaterThanY(int[] arr, int y )
        {
            int count = 0;
            foreach(int val in arr)
            {
                if(val > y)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} greater than {y} ");
        }

        //square all values in arr
        public static void SquareAllValues(int[] arr)
        {
            for(int idx = 0; idx < arr.Length; idx++)
            {
                arr[idx] *= arr[idx]; 
            }
        }

        //eliminate negitive values in array
        public static void ReplaceNegative(int[] arr)
        {
            for(int idx = 0; idx < arr.Length; idx++ )
            {
                if(arr[idx] < 0)
                {
                    arr[idx] = 0;
                }
            }
        }

        //retrieve min, max, avg of array
        public static void MinMaxAvg(int[] arr)
        {
        int sum = 0;
        int min = arr[0];
        int max = arr[0];
        foreach(int val in arr)
            {
                sum += val;
                if(val < min)
                {
                    min = val;
                }
                if(val > max)
                {
                    max = val;
                }
            }
            Console.WriteLine("Min: {0} Max: {1} Avg: {2}", min, max, (double)sum/(double)arr.Length);
        }

        //shift array to front by one number and add 0 to the end
        public static void ShiftLeft(int[] arr)
        {
            for(int idx = 0; idx > arr.Length; idx++)
            {
                arr[idx] = arr[idx + 1];
            }
            arr[arr.Length - 1] = 0;
        }

        //replace negatives with the string of dojo
        public static object[] ReplaceNumString(object[] arr)
        {
            for(int idx = 0; idx < arr.Length; idx++)
            {
                if((int)arr[idx] < 0)
                {
                    arr[idx] = "Dojo";
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNum();
            Console.WriteLine();
            PrintOdd();
            Console.WriteLine();
            PrintSum();
            Console.WriteLine();
            int[] newArr = new int[6] {1,4,3,9,22,51};
            IterateArr(newArr);
            Console.WriteLine();
            FindMax(newArr);
            Console.WriteLine();
            int[] y = new int[8] {-3, -5, -7, 1, 3 , 5 ,10, 25};
            FindMin(y);
            Console.WriteLine();
            FindAvg(y);
            Console.WriteLine();
            CreateOddArray();
            Console.WriteLine();
            GreaterThanY(newArr, 4);
            Console.WriteLine();
            ReplaceNegative(newArr); //passed by reference
            SquareAllValues(newArr); //passed by reference
            MinMaxAvg(newArr);
            ShiftLeft(newArr);
        }
    }
}
