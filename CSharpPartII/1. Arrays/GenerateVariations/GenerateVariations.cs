using System;

namespace GenerateVariations
{
    class GenerateVariations
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Pow(n, k); i++)
            {
                int conv = i;
                int[] num = new int[k];
                for (int j = 0; j < k; j++)
                {
                    num[k - j - 1] = conv % n;
                    conv = conv / n;
                }

                Console.Write("{0}{1}", '{', num[0] + 1);
                for (int j = 1; j < k; j++)
                {
                    Console.Write(", {0}", num[j] + 1);
                }
                Console.WriteLine("}");
            }            
        }
    }
}
