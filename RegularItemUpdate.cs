using GildedRoseKata;

public class RegularItemUpdate : UpdatableItem
{
    public RegularItemUpdate(Item item) : base(item) { }

    public override void Update()
    {
        if (item.SellIn < 0 && item.Quality > 0) item.Quality = item.Quality - 1;
        if (item.Quality > 0) item.Quality = item.Quality - 1;
        item.SellIn = item.SellIn - 1;
    }
}