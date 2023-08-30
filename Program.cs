using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tamgiac tamGiac1 = new Tamgiac(4, 5, 6); // Tam giác thường
            Tamgiac tamGiac2 = new Tamgiac(-1, 2, 3); // Hình vi phạm ràng buộc
            Tamgiac tamGiac3 = new Tamgiac(8, 8, 8); // Tam giác đều
            Tamgiac tamGiac4 = new Tamgiac(7, 5, 7); // Tam giác cân
            Tamgiac tamGiac5 = new Tamgiac(9, 10, 13); // Tam giác thường

            Tamgiac[] danhSachTamGiac = { tamGiac1, tamGiac2, tamGiac3, tamGiac4, tamGiac5 };

            Console.WriteLine("{0,-15}{1,-20}{2,-10}{3,-10}", "Tam giác", "Kiểu tam giác", "Chu vi", "Diện tích");
            Console.WriteLine(new string('-', 55));
            for (int i = 0; i < danhSachTamGiac.Length; i++)
            {
                Console.WriteLine("Tam giác {0}: {1}", i + 1, danhSachTamGiac[i]);
            }
            Console.ReadLine();
        }
    }
}
