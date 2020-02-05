using System;

namespace CreditCard
{
    public interface ICommonCreditCard
    {
        void CashIn(double value);
        void CashOut(double value);
    }
    public interface IPremiumCreditCard : ICommonCreditCard 
    {
        void GainBonus(ICommonCreditCard operation);
    }
    public interface IPlatinumCreditCard : IPremiumCreditCard
    {
        void GainMiles(ICommonCreditCard operation);
    }



    public class CardProperties : ICommonCreditCard 
    {
        public double Balance = 0;
        public double Commision;

        public void CashOut(double value)
        {
            if (Balance >= value)
            {
                Balance -= value + (value * Commision);
            }
            else
            {
                throw new Exception("Недостаточно средств");
            }
        }
        
        public void CashIn(double value)
        {
            Balance += value - value * Commision;
        }
        public double GetBalance() 
        {
            return Balance;
        }
    }

    public class CommonCard : CardProperties
    {
        public CommonCard() => Commision = 0.03;
    }
    class PremiumCard : CardProperties
    {
        public PremiumCard() => Commision = 0.02;
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
