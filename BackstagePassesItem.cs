using GildedRoseKata;

public class BackstagePassesItem : UpdatableItem
{
    private Item item;

    public BackstagePassesItem(Item item)
    {
        this.item = item;
    }

    public override void Update()
    {
        if (item.Quality < 50) item.Quality = item.Quality + 1;
        if (item.Quality < 50 && item.SellIn < 11) item.Quality = item.Quality + 1;
        if (item.Quality < 50 && item.SellIn < 6) item.Quality = item.Quality + 1;
        if (item.SellIn <= 0) item.Quality = 0;
    }
}
