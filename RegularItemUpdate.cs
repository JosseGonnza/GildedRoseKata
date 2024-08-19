using GildedRoseKata;

public class RegularItemUpdate : UpdatableItem
{
    private Item item;

    public RegularItemUpdate(Item item)
    {
        this.item = item;
    }

    public override void Update()
    {
        if (item.SellIn < 0 && item.Quality > 0) item.Quality = item.Quality - 1;
        if (item.Quality > 0) item.Quality = item.Quality - 1;
        item.SellIn = item.SellIn - 1;
    }
}