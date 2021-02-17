using System;
using System.Collections.Generic;
using System.Diagnostics;

    public class TestaAdicionaNoComeco
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            long tempo = TestaAdicionaNoComeco.AdicionaNoComecoList(list);
            Console.WriteLine("list: " + tempo + "ms");
        }

        public static long AdicionaNoComecoList(List<int> lista){
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int size = 100000;

            for(int i = 0; i < size; i++){
                lista.Insert(0, i);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public static long AdicionaNoComecoLinkedList(LinkedList<int> lista){
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int size = 100000;

            for(int i = 0; i < size; i++){
                lista.AddFirst(i);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
