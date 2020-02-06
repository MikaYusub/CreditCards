using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonCard common = new CommonCard();
            double v = common.GetBalance();
            Console.WriteLine(v);
            common.CashIn(22.40);
            common.CashOut(12.40);
            v = common.GetBalance();
            Console.WriteLine(v);

        }
    }
}
