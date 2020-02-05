using System;

namespace CreditCard
{
    public class CommonCardProperties : ICommonCreditCard
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
}
