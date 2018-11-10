namespace GildedRose.Console
{
    public class CheeseItem : UpdateableItem
    {
        public override void Update()
        {
            IncreaseQualityIfLowerThanFifty();

            DecreaseSellIn();

            if (SellIn < 0)
            {
                IncreaseQualityIfLowerThanFifty();
            }
        }
    }
}