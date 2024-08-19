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
                if (item.Name == "Aged Brie") AgedBrieUpdate(item);

                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert") BackstagePassesUpdate(item);

                else if (item.Name == "Sulfuras, Hand of Ragnaros") SulfurasUpdate(item);

                else RegularItemUpdate(item);
            }
        }
        private void AgedBrieUpdate(Item item)
        {
            new AgedBrieItem(item).Update();
        }

        private void BackstagePassesUpdate(Item item)
        {
            new BackstagePassesItem(item).Update();
        }

        public void SulfurasUpdate(Item item)
        {
            new SulfurasItem(item).Update();
        }

        public void RegularItemUpdate(Item item)
        {
            new RegularItemUpdate(item).Update();
        }
    }
}



public class AgedBrieItem
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

public class BackstagePassesItem
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

public class SulfurasItem
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

public class RegularItemUpdate
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