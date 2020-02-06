using System;

namespace Facility
{
    class Airline 
    {
        public void BuyForMiles(CreditCard.PlatinumCard card_type, int value) 
        {
            if (card_type.miles < value)
            {
                throw new Exception("Недостаточно миль");
            }
            else
            {
                card_type.miles -= value;
            }
        }
    
    }


}
