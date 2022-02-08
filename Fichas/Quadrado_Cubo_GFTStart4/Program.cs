/**
 *
 * @author André Filipe
 */
using System;

namespace Quadrado_Cubo_GFTStart4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n != null && n.GetType() == typeof(int))
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i} {i * i} {i * i * i}");
                }
            }
            return;
        }
    }
}