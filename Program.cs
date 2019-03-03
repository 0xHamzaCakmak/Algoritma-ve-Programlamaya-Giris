using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harf_notu_man_op_li
{
    class Program
    {
        static void Main(string[] args)
        {
            //Harf notu Mantıksal operatör ile çözümü...
            //Yaklaşık değerler verilmiştir
            Console.WriteLine("0 ile 100 Arasında Deger Giriniz");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not <= 100 && not >= 85)
                Console.WriteLine("AA");
            if (not <= 84 && not >= 75)
                Console.WriteLine("BA");
            if (not <= 74 && not >= 65)
                Console.WriteLine("BB");
            if (not <= 64 && not >= 60)
                Console.WriteLine("CB");
            if (not <= 59 && not >= 50)
                Console.WriteLine("CC");
            if (not <=49 && not >= 0)
                Console.WriteLine("FF");
        }
    }
}
