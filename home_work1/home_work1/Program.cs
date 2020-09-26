using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int tmp_1 = 0, tmp_2 = 0;
            tmp_1 = num * num;
            Console.WriteLine(tmp_1);
            tmp_2 = tmp_1 * num;
            Console.WriteLine(tmp_2);
            tmp_1 *= tmp_2;
            Console.WriteLine(tmp_1);
            tmp_2 = tmp_1 * tmp_1;
            Console.WriteLine(tmp_2);
            tmp_1 *= tmp_2;
            Console.WriteLine(tmp_1);

        }
    }
}
