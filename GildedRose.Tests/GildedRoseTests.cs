using System;
using System.Collections.Generic;
using Xunit;

namespace gildedrose.tests
{
    public class GildedRoseTests
    {
        [Fact]
        public void foo()
        {
            List<Item> Items = new List<Item> { new Item("foo", 0, 0) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("fixme", Items[0].Name);
        }

        public void example()
        {
            List<Item> Items = new List<Item>
            {
                new Item("+5 Dexterity Vest", 10, 20),
                new Item("Aged Brie", 2, 0),
                new Item("Elixir of the Mongoose", 5, 7),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new Item("Conjured Mana Cake", 3, 6)
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
        }
    }
}
