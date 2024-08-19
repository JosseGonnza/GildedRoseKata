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
