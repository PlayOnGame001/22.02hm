using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02hm
{
    internal class Bank : Nick
    {
        private int sum;

        public Bank() { }
        public Bank(int pin, int sum)
        {
            this.sum = sum;
        }
        public void EnterSum(int sum)
        {
            Console.WriteLine($"Wait a minute processed started...\nIssuance finish: {sum} euro");
        }
    }
}