namespace GildedRoseKata
{
    public class ConjuredItem : UpdatableItem
    {
        private Item item;

        public ConjuredItem(Item item)
        {
            this.item = item;
        }

        public override void Update()
        {
            item.Quality -= 2;
        }
    }
}