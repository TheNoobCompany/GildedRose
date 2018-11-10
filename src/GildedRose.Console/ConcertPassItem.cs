namespace GildedRose.Console
{
    public class ConcertPassItem : UpdateableItem
    {
        public override void Update()
        {
            IncreaseQualityIfLowerThanFifty();

            if (SellIn < 11)
            {
                IncreaseQualityIfLowerThanFifty();
            }

            if (SellIn < 6)
            {
                IncreaseQualityIfLowerThanFifty();
            }

            DecreaseSellIn();

            ResetQualityIfExpired();
        }
    }
}