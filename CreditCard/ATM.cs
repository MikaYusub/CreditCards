namespace Facility
{
    class ATM
    {
        public void CashIn(CreditCard.CommonCard card_type, double value) => card_type.CashOut(value);

        public void CashOut(CreditCard.CommonCard card_type, double value) => card_type.CashIn(value);
        public void CashIn(CreditCard.PremiumCard card_type, double value) => card_type.CashOut(value);

        public void CashOut(CreditCard.PremiumCard card_type, double value) => card_type.CashIn(value);
        public void CashIn(CreditCard.PlatinumCard card_type, double value) => card_type.CashOut(value);

        public void CashOut(CreditCard.PlatinumCard card_type, double value) => card_type.CashIn(value);
    }


}
