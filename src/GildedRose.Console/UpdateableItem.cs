namespace GildedRose.Console
{
    public abstract class UpdateableItem : Item
    {
        public abstract void Update();

        public void ResetQualityIfExpired()
        {
            if (SellIn < 0)
            {
                Quality = 0;
            }
        }

        public void DecreaseQualityIfGreaterThanZero()
        {
            if (Quality > 0)
            {
                Quality--;
            }
        }

        public void IncreaseQualityIfLowerThanFifty()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }

        public void DecreaseSellIn()
        {
            SellIn--;
        }
    }
}