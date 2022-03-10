using System;

namespace tpmodul3_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Kelurahan: \n");
            string kel = Console.ReadLine();
            KodePos kode = new KodePos();
            Console.Write(kode.getKodePos(kel));
            
        }
    }
}
