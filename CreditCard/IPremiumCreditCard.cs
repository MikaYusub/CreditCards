namespace CreditCard
{
    public interface IPremiumCreditCard : ICommonCreditCard
    {
        public void GainBonus();
        void CommisionTurnOn();
        void CommisionTurnOff();

    }
}
