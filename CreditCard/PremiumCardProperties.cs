namespace CreditCard
{
    public class PremiumCardProperties : CommonCardProperties, IPremiumCreditCard
    {
        public void CommisionTurnOff() => commision = 0;

        public void CommisionTurnOn() => commision = 0.02;

        public void GainBonus()
        {
            if (GetIsMethodsCalled() == true) 
            {
                bonusBalance++;
            }
        }
    }
}
