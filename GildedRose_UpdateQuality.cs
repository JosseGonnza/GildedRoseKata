using FluentAssertions;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GildedRoseKata
{
    public class GildedRose_UpdateSulfuras
    {
        [Fact]
        public void DoesNothingGivenSulfuras()
        {
            int initialQuality = 80;
            var items = new List<Item> {
                                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = initialQuality},

            };
            var gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            var firstItem = items.First();

            // Use your preferred assertion library (already included - pick one delete others)
            // xunit default
            Assert.Equal(initialQuality, firstItem.Quality);

            // fluentassertions
            firstItem.Quality.Should().Be(initialQuality);

            // shouldly
            firstItem.Quality.ShouldBe(initialQuality);
        }
    }

    public class GildedRose_UpdateQuality
    {
        [Fact(DisplayName = "At the end of each day quality is reduced by 1")]
        public void Quality_should_is_reduce_by_1_at_the_end_of_each_day()
        {
            var fooItem = new Item { Name = "foo", Quality = 10, SellIn = 5 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(9);
        }
        
        [Fact(DisplayName = "When the sellIn ends, quality is reduce by 2")]
        public void Quality_should_is_reduce_by_2_when_the_sellIn_ends()
        {
            var fooItem = new Item { Name = "foo", Quality = 10, SellIn = 0 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(8);
        }

        [Fact(DisplayName = "Quality never is negative")]
        public void Quality_never_is_negative()
        {
            var fooItem = new Item { Name = "foo", Quality = 0, SellIn = 5 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(0);
        }

        [Fact(DisplayName = "Quality never is more than 50")]
        public void Quality_never_is_more_than_50()
        {
            var fooItem = new Item { Name = "Aged Brie", Quality = 50, SellIn = 5 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(50);
        }

        [Fact(DisplayName = "AgedBrie quality increases when sellIn decreases")]
        public void Quality_of_AgedBrie_increases_when_sellIn_decreases()
        {
            var fooItem = new Item { Name = "Aged Brie", Quality = 10, SellIn = 5 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(11);
        }

        [Fact(DisplayName = "BackstagePasses quality increases when sellIn decreases")]
        public void Quality_of_BackstagePasses_increases_when_sellIn_decreases()
        {
            var fooItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 20 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(11);
        }

        [Fact(DisplayName = "BackstagePasses quality increases 2 when sellIn decreases by 10 or more")]
        public void Quality_of_BackstagePasses_increases_2_when_sellIn_decreases_by_10_or_more()
        {
            var fooItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(12);
        }

        [Fact(DisplayName = "BackstagePasses quality increases 3 when sellIn decreases by 5 or more")]
        public void Quality_of_BackstagePasses_increases_3_when_sellIn_decreases_by_5_or_more()
        {
            var fooItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(13);
        }

        [Fact(DisplayName = "BackstagePasses quality decreases 0 when sellIn decreases by 0")]
        public void Quality_of_BackstagePasses_decreases_0_when_sellIn_decreases_by_0()
        {
            var fooItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 0 };
            var gildedRose = new GildedRose(new List<Item> { fooItem });

            gildedRose.UpdateQuality();

            fooItem.Quality.Should().Be(0);
        }
    }

    public class GildedRose_UpdateSellIn
    {
        [Fact(DisplayName = "At the end of each day sellIn is reduced by 1")]
        public void SellIn_should_is_reduce_by_1_at_the_end_of_each_day()
        {
            var fooItem = new Item { Name = "foo", Quality = 10, SellIn = 5 };
            var gildedRose = new GildedRose(new List<Item> { fooItem});
            
            gildedRose.UpdateQuality();

            fooItem.SellIn.Should().Be(4);
        }

    }
}
