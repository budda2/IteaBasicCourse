namespace ExampleWithFakeDb.Buisness
{
    public class Commodity
    {
        public int Price { get; private set; }
        public string Title { get; private set; }

        public Commodity(int price, string title)
        {
            Price = price;
            Title = title;
        }
    }
}
