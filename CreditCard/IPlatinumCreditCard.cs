namespace CreditCard
{
    public interface IPlatinumCreditCard : IPremiumCreditCard
    {
        void GainMiles(ICommonCreditCard operation);
    }
}
