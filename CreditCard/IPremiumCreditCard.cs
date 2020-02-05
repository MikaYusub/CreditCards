namespace CreditCard
{
    public interface IPremiumCreditCard : ICommonCreditCard
    {
        void GainBonus(ICommonCreditCard operation);
        void CommisionTurnOn();
        void CommisionTurnOff();

    }
}
