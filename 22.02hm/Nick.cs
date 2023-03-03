using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02hm
{
    internal class Nick
    {
        public Nick() { }
        public void Print(int sum)
        {
            Console.WriteLine($"Issuance finish: {sum} euro");
        }
        public void NoPrint()
        {
            Console.WriteLine("Nick will not printed");
        }
    }
}