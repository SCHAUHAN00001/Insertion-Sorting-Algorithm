using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sorting_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 5, 1, 3, 7, 2, 6, 4, 8 };
            InsertionSort(a, 9);
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
        public static void InsertionSort(int[] A , int N)
        {
            for(int i=1;i<N;i++)
            {
                int cvalue = A[i];
                int position = i;
                while(position>0 && A[position-1] > cvalue)
                {
                    A[position] = A[position-1];
                    position = position-1;
                    
                }
                A[position] = cvalue;


            }
            
        }
    }
}
