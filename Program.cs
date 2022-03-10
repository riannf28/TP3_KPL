using System;

namespace tpmodul3_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelurahan & Kode Pos");
            Console.WriteLine("Input Kelurahan: ");
            string kel = Console.ReadLine();
            KodePos kode = new KodePos();
            Console.WriteLine(kode.getKodePos(kel));

            Console.WriteLine("\nDoor Machine");
            Console.Write("State Awal: ");
            DoorMachine door = new DoorMachine();
            Console.WriteLine("\nInput state: ");
            string state = Console.ReadLine();
            if (state == "Terbuka")
            {
                door.Terbuka();
            }
            else if (state == "Terkunci") 
            {
                door.Terkunci();
            }
            else
            {
                Console.WriteLine("Coba masukkan kata kunci 'Terbuka' atau 'Terkunci'");
            }
        }
    }
}
