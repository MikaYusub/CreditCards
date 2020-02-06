namespace CreditCard
{
    public class PlatinumCardProperties : PremiumCardProperties, IPlatinumCreditCard
    {
        public new static int miles = 0;

        public void GainMiles()
        {
            if (GetIsMethodsCalled() == true)
            {
                miles++;
            }
        }
    }
}
