using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program189
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Номер разряда (1—Юношеский, 2—Взрослый, 3—КМС, 4—МС, 5—МСМК): ");
            if (!int.TryParse(Console.ReadLine(), out int rank) || rank < 1 || rank > 5)
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string full;
            switch (rank)
            {
                case 1: full = "Юношеский разряд"; break;
                case 2: full = "Взрослый разряд"; break;
                case 3: full = "Кандидат в мастера спорта (КМС)"; break;
                case 4: full = "Мастер спорта (МС)"; break;
                case 5: full = "Мастер спорта международного класса (МСМК)"; break;
                default: return;
            }
            Console.WriteLine(full);
        }
    }
}