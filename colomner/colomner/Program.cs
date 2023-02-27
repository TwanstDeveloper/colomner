using System;
namespace ConsoleApp10
{
    class Program
    {
        string enc(string msg, int k)
        {
            string sipher = "";
            int col = k;
            int row = (int)Math.Ceiling((double)(msg.Length / k));
            char[,] arr = new char[row, col];
            int kk = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = msg[kk];
                    Console.Write(arr[i, j]);
                    kk++;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sipher = sipher + arr[j, i];
                }

            }
            Console.WriteLine(sipher);
            Console.WriteLine("\n");
            return sipher;
        }
        void dec(string msg, int k)
        {
            string plain = "";
            int col = k;
            int row = (int)Math.Ceiling((double)(msg.Length / k));
            char[,] arr = new char[row, col];
            int kk = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[j, i] = msg[kk];
                    Console.Write(arr[j, i]);
                    kk++;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            string msgs = "qwertyuiopasdfghjklmnbvcx";
            int kes = 5;
            Program ob = new Program();
            string c = ob.enc(msgs, kes);
            ob.dec(c, kes);
            Console.ReadKey();
        }
    }
}