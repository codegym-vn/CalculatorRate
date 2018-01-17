using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input money: ");
            var m = Console.ReadLine();
            Console.WriteLine("Please input rate: ");
            var r = Console.ReadLine();
            Console.WriteLine("Please input time deposit:");
            var tl = Console.ReadLine();

            var isValidMoney = decimal.TryParse(m, out decimal money);
            var isValidRate = decimal.TryParse(r, out decimal rate);
            var isValidTimeLoan = int.TryParse(tl, out int timeLoan);
            decimal total = 0;

            if (isValidMoney && isValidRate && isValidTimeLoan)
            {
                for (int i = 0; i < timeLoan; i++)
                {
                    if (i == 0) total = money + money * rate/100;
                    else total += total * rate/100;
                }
                Console.WriteLine("Total: " + total);
            }
            else
            {
                Console.WriteLine("Data invalid!");
            }
            Console.ReadLine();
        }
    }
}
