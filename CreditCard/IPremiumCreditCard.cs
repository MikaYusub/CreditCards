namespace CreditCard
{
    public interface IPremiumCreditCard : ICommonCreditCard
    {
        void GainBonus();
        void CommisionTurnOn();
        void CommisionTurnOff();

    }
}
