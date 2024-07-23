namespace PenktaPaskaitaCSharp.Models
{
    public class Item
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Item()
        {

        }
        public Item(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }

        public double CountSum(int count, double price)
        {
            return count * price;
        }

        public override string ToString()
        {
            return $"{Name}: count: {Count} and price per item {Price} Eur. Total Price is: {Math.Round(CountSum(Count, Price), 2)} Eur.";
        }
    }
}
