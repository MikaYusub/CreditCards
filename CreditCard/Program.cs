using System;

namespace CreditCard
{

    public class PremiumCardProperties : CommonCardProperties, IPremiumCreditCard
    {
        public void CommisionTurnOff() => Commision = 0;

        public void CommisionTurnOn() => Commision = 0.02;

        public void GainBonus(ICommonCreditCard operation)
        {
            throw new NotImplementedException();
        }
    }
    public class CommonCard : CommonCardProperties
    {
        public CommonCard() => Commision = 0.03;
    }
    public class PremiumCard : PremiumCardProperties
    {
        public PremiumCard() => Commision = 0.02;
    }
    public class PlatinumCard : CommonCardProperties 
    {
        public PlatinumCard() => Commision = 0.01;
    }

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
