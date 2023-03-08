using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class Calculate
    {
        private static long Moves = 0;
        public static void Towers(int number, int from, int to, int free)
        {
            if (number == 0)
                return;
            Towers(number - 1, from, free, to);
            Console.WriteLine($"{++Moves}_from: {from} To: {to}");
            Towers(number - 1, free, to, from);
        }
    }
}
