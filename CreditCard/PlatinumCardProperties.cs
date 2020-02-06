namespace CreditCard
{
    public class PlatinumCardProperties : PremiumCardProperties, IPlatinumCreditCard
    {
        public void GainMiles()
        {
            if (GetIsMethodsCalled() == true)
            {
                miles++;
            }
        }
    }
}
