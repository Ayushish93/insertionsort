using System;
using System.IO;

namespace HelloWorld
{
   

    class Program
    {   // 0 1 2 3 4
        // 2 4 5 8 3
        static void insertionSort1(int n, int[] arr)
        {
            int num = arr[n - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                
                    if (i != 0 && num < arr[i - 1])
                    {
                        int swapnum = arr[i - 1];
                        arr[i] = swapnum;
                        arr[i - 1] = swapnum;
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr[j] + " ");

                        }
                        Console.Write("\n");
                    }
                    else
                    {

                        arr[i] = num;

                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr[j] + " ");

                        }
                        Console.Write("\n");
                        break;

                    }
                
            }

        }


        static void Main(string[] args)
        {



            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            insertionSort1(n, arr);
        }


    }
}
