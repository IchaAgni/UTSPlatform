using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konversiNilai;

class Program
{
    static void Main(string[] args)
    {

        int nilai;
        string name = "Icha";
        //Input
        Console.Write("Masukan Nama : ");
        string nama = Console.ReadLine();
        Console.Write("Masukan Nilai : ");
        nilai = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        // Console.WriteLine("nilai is {0}.", nilai);
        Console.WriteLine("\n");
        if (nilai >= 75)
        {
            Console.WriteLine("Name {0} ", nama);
            Console.WriteLine("nilai A.", nilai);
        }
        else if (nilai >= 75)
        {
            Console.WriteLine("Nama {0} ", nama);
            Console.WriteLine("nilai A.", nilai);
        }
        else if (nilai >= 60)
        {
            Console.WriteLine("Nama {0} ", nama);
            Console.WriteLine("nilai B.", nilai);
        }
        else if (nilai >= 50)
        {
            Console.WriteLine("Nama {0} ", nama);
            Console.WriteLine("nilai C.", nilai);
        }
        else if (nilai >= 40)
        {
            Console.WriteLine("Nama {0} ", nama);
            Console.WriteLine("nilai D.", nilai);
        }
        else
        {
            Console.WriteLine("Nama {0} ", nama);
            Console.WriteLine("nilai E.", nilai);
        }
    }
}