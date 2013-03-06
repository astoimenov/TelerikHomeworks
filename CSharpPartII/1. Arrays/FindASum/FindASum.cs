using System;

namespace FindASum
{
    class FindASum
    {
        static void Main()
        {
            int wantedSum; 
            int n; 
            int tempSum = 0; 
            int index = 0; 
            int counter = 0; 
            int currentCounter = 0; 

            Console.Write("S = ");
            wantedSum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of elements:");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)            
            {
                for (int j = i; j < arr.Length - 1; j++)        
                {
                    tempSum += arr[j];                         
                    currentCounter++;                          

                    if (tempSum == wantedSum)                   
                    {

                        if (currentCounter > counter)          
                        {
                            counter = currentCounter;           
                            index = j;                          
                        }
                    }
                }

                currentCounter = 0;                            
                tempSum = 0;                                    
            }

            if (tempSum == wantedSum)                         
            {
                for (int i = counter - 1; i >= 0; i--)         
                {                                           
                    Console.Write(arr[index - i] + " ");        
                }                                              
            }                                                   
            else                                               
            {
                Console.WriteLine("There is no sequence in the array equal to {0}", wantedSum);
            }
        }
    }
}
