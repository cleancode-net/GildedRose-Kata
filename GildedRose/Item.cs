namespace gildedrose
{
    internal class Item
    {
        public string Name
        {
            get; set;
        }

        public int SellIn
        {
            get; set;
        }

        public int Quality
        {
            get; set;
        }

        public Item(string Name, int SellIn, int Quality)
        {
            this.Name = Name;
            this.SellIn = SellIn;
            this.Quality = Quality;
        }
    }
}
