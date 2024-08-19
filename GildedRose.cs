using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace GildedRoseKata;

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
            CreateUpdatableItem(item).Update();
        }
    }

    public IUpdatableItem CreateUpdatableItem(Item item)
    {
        return item.Name switch
        {
            "Aged Brie" => new AgedBrieItem(item),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassesItem(item),
            "Sulfuras, Hand of Ragnaros" => new SulfurasItem(item),
            _ => new RegularItemUpdate(item)
        };
    }
}
