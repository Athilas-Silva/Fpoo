using System;
using System.Collections.Generic;
using System.Diagnostics;

    public class TestaContains
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            HashSet<int> hashSet = new HashSet<int>();

            long tempo = TestaContains.Contains(list);
            Console.WriteLine("List: " + tempo + "ms");

            tempo = TestaContains.Contains(hashSet);
            Console.WriteLine("HashSet: " + tempo + "ms");
        }
        public static long Contains(ICollection<int> colecao){
            int size = 10000;

            for(int i = 0; i < size; i++){
                colecao.Add(i);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < size; i++)
            {
                colecao.Contains(i);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }