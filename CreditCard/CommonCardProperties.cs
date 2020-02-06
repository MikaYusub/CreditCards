using System;

namespace CreditCard
{
    public class CommonCardProperties : ICommonCreditCard
    {
        public double balance = 0;
        public static int bonusBalance = 0;
        public static int miles = 0;
        public double commision;
        private bool isMethodsCalled = false;

        public void CashOut(double value)
        {
            if (balance >= value)
            {
                balance -= value + (value * commision);
                isMethodsCalled = true;

            }
            else
            {
                throw new Exception("Недостаточно средств");
            }
        }

        public void CashIn(double value)
        {
            balance += value - value * commision;
            isMethodsCalled = true;
        }
        public double GetBalance() => balance;
        public bool GetIsMethodsCalled() => isMethodsCalled;
    }
}
