namespace GildedRose.Console
{
    public class CommonItem : UpdateableItem
    {
        public override void Update()
        {
            DecreaseQualityIfGreaterThanZero();

            DecreaseSellIn();

            if (SellIn < 0)
            {
                DecreaseQualityIfGreaterThanZero();
            }
        }
    }
}