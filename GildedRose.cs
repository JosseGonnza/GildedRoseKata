using GildedRoseKata;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> _items;
        public GildedRose(IList<Item> item)
        {
            this._items = item;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if (item.Name == "Aged Brie") new AgedBrieItem(item).Update();


                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert") new BackstagePassesItem(item).Update();


                else if (item.Name == "Sulfuras, Hand of Ragnaros") new SulfurasItem(item).Update();


                else new RegularItemUpdate(item).Update();

            }
        }
    }
}

public interface IUpdatableItem
{
    void Update();
}

public class AgedBrieItem : IUpdatableItem
{
    private Item item;

    public AgedBrieItem(Item item)
    {
        this.item = item;
    }

    public void Update()
    {
        if (item.SellIn < 0 && item.Quality < 50) item.Quality = item.Quality + 1;
        if (item.Quality < 50) item.Quality = item.Quality + 1;
    }
}

public class BackstagePassesItem : IUpdatableItem
{
    private Item item;

    public BackstagePassesItem(Item item)
    {
        this.item = item;
    }

    public void Update()
    {
        if (item.Quality < 50) item.Quality = item.Quality + 1;
        if (item.Quality < 50 && item.SellIn < 11) item.Quality = item.Quality + 1;
        if (item.Quality < 50 && item.SellIn < 6) item.Quality = item.Quality + 1;
        if (item.SellIn <= 0) item.Quality = 0;
    }
}

public class SulfurasItem : IUpdatableItem
{
    private Item item;

    public SulfurasItem(Item item)
    {
        this.item = item;
    }

    public void Update()
    {
        return;
    }
}

public class RegularItemUpdate : IUpdatableItem
{
    private Item item;

    public RegularItemUpdate(Item item)
    {
        this.item = item;
    }

    public void Update()
    {
        if (item.SellIn < 0 && item.Quality > 0) item.Quality = item.Quality - 1;
        if (item.Quality > 0) item.Quality = item.Quality - 1;
        item.SellIn = item.SellIn - 1;
    }
}