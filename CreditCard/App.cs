    class App
    {
        static void Main(string[] args)
        {
        CreditCard.CommonCard cc = new CreditCard.CommonCard();
        CreditCard.PlatinumCard pc = new CreditCard.PlatinumCard();
        Facility.Airline airline = new Facility.Airline();
        cc.CashIn(22);
        pc.CashIn(10);
        pc.GainMiles();
        }
    }
