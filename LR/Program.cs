using System;
using System.Linq;

namespace LR
{
    class LR
    {
        public int nrElem;
        public int[] a;


        public void Formare(int n)
        {
            nrElem = n;
            string readLine = Console.ReadLine();
            string[] stringArray = readLine.Split(' ');
            a = new int[nrElem];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(stringArray[i]);
            }
        }
        public void isLR()
        {
            bool stanga = false;
            bool dreapta = false;
            int nrLR = 0;
            for (int i = 1; i < nrElem-1; i++)
            {
                for (int x = i-1; x >= 0; x--)
                {
                    if (a[i] >= a[x])
                    {
                        stanga = true;
                    }
                    else
                    {
                        stanga = false;
                        break;
                    }
                }
                for (int y = i+1; y < nrElem; y++)
                {
                    if (a[i] <= a[y])
                    {
                        dreapta = true;
                    }
                    else
                    {
                        dreapta = false;
                        break;
                    }
                }
                if (stanga == true && dreapta == true)
                {
                    nrLR++;
                }
            }
            Console.WriteLine("Sunt " + nrLR + " elemente LR");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numarul de elemente din vector = ");
            int n = int.Parse(Console.ReadLine());
            LR vector = new LR();
            Console.WriteLine("Elementele vectorului (separate prin spatiu  ex: 1 2 3) :");
            vector.Formare(n);
            vector.isLR();            
        }
    }
}
