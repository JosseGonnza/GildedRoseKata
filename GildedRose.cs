using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> _items;
    public GildedRose(IList<Item> item)
    {
        this._items = item;
    }

    public Dictionary<string, Func<Item, UpdatableItem>> UpdatableItemTable = new()
    {
        { "Aged Brie", (item) => new AgedBrieItem(item) },
        { "Backstage passes to a TAFKAL80ETC concert", (item) => new BackstagePassesItem(item) },
        { "Sulfuras, Hand of Ragnaros", (item) => new UpdatableItem(item) },
        { "Default", (item) => new RegularItemUpdate(item) }
    };

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            CreateUpdatableItem(item).Update();
        }
    }

    public UpdatableItem CreateUpdatableItem(Item item)  // kvp means KeyValuePair
    {
        return UpdatableItemTable.First((kvp) => kvp.Key.Equals(item.Name) || kvp.Key.Equals("Default")).Value(item);  // Value is a function(item)
    }
}
