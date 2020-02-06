using System;

namespace Facility
{
    class Shop
    {
        public void BuyForBonuses(CreditCard.PremiumCard card_type, int value) 
        {
            if (card_type.bonusBalance < value)
            {
                throw new Exception("Недостаточно бонусов");
            }
            else 
            {
                card_type.bonusBalance -= value;      
            }
        }
        public void BuyForBonuses(CreditCard.PlatinumCard card_type, int value)
        {
            if (card_type.bonusBalance < value)
            {
                throw new Exception("Недостаточно бонусов");
            }
            else
            {
                card_type.bonusBalance -= value;
            }
        }
    }

}
