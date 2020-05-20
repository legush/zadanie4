using System;
using System.Collections;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList() { 856, 3, "m", 78, 65, 9.6, "g", "H", 443, 54, 41.21, 95, "a", 3.21 };

            for (int i = 0; i < a.Count; i++) {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < a.Count; i++) {
                if (a[i] is string) {
                    a.RemoveAt(i);
                    if (a[i] is string) i--;
                }
            }

            for (int i = 0; i < a.Count; i++) {
                Console.Write(a[i] + " ");
            }
        }
    }
}