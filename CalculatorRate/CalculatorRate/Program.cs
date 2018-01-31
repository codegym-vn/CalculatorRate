using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input money: ");
            string inputMoney = Console.ReadLine();
            Console.WriteLine("Please input rate: ");
            string inputRate = Console.ReadLine();
            Console.WriteLine("Please input time deposit:");
            string inputTimeLoan = Console.ReadLine();

            decimal money = decimal.Parse(inputMoney);
            decimal rate = decimal.Parse(inputRate);
            decimal timeLoan = int.Parse(inputTimeLoan);

            if (money > 0 && rate > 0 && timeLoan > 0)
            {
                for (int i = 0; i < timeLoan; i++)
                {
                    money += money * rate / 100;
                }
            }
            else
            {
                Console.WriteLine("Invalid data");
            }

            Console.WriteLine("Total: " + money);
            Console.ReadLine();
        }
    }
}
