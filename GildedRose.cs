﻿using System.Collections.Generic;

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
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert" && item.Name != "Sulfuras, Hand of Ragnaros" && item.Quality > 0) item.Quality = item.Quality - 1;
                if (item.Name == "Aged Brie" && item.Quality < 50) item.Quality = item.Quality + 1;
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && item.Quality < 50) item.Quality = item.Quality + 1;

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && item.Quality < 50 && item.SellIn < 11) item.Quality = item.Quality + 1;
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && item.Quality < 50 && item.SellIn < 6) item.Quality = item.Quality + 1;

                if (item.Name != "Sulfuras, Hand of Ragnaros") item.SellIn = item.SellIn - 1;

                if (item.Name != "Aged Brie" && item.Name != "Sulfuras, Hand of Ragnaros" && item.SellIn < 0 && item.Quality > 0) item.Quality = item.Quality - 1;
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && item.SellIn < 0) item.Quality = 0;
                if (item.Name == "Aged Brie" && item.SellIn < 0 && item.Quality < 50) item.Quality = item.Quality + 1;
            }
        }
    }
}
