using System;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (IsAgedBrie(i) || IsBackstagePasses(i))
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (IsBackstagePasses(i))
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality > 0)
                    {
                        if (IsSulfuras(i))
                        {
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }

                if (IsSulfuras(i))
                {
                }
                else
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (IsAgedBrie(i))
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                    else
                    {
                        if (IsBackstagePasses(i))
                        {
                            Items[i].Quality = 0;
                        }
                        else
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (IsSulfuras(i))
                                {
                                    continue;
                                }
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                }
            }
        }

        private bool IsSulfuras(int i)
        {
            return Items[i].Name == "Sulfuras, Hand of Ragnaros";
        }

        private bool IsBackstagePasses(int i)
        {
            return Items[i].Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        private bool IsAgedBrie(int i)
        {
            return Items[i].Name == "Aged Brie";
        }
    }
}
