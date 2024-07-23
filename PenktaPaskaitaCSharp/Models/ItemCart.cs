namespace PenktaPaskaitaCSharp.Models
{
    public class ItemCart
    {
        public Item[] Items { get; set; }
        int lastAdded = 0;
        int itemCount = 0;
        public ItemCart()
        {
            Items = new Item[1000];
        }

        public void AddItem(Item item)
        {
            Items[lastAdded] = item;
            lastAdded++;
            itemCount++;
        }

        public void RemoveItem(string name)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (Items[i].Name == name)
                {
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        Items[j] = Items[j + 1];
                    }
                    Items[itemCount - 1] = null;
                    itemCount--;
                    break;
                }
            }
        }

        public double TotalPrice(Item[] cart)
        {
            double totalCartPrice = 0;
            foreach (Item item in cart)
            {
                if (item == null)
                {
                    break;
                }

                totalCartPrice += item.CountSum(item.Count, item.Price);
            }

            return Math.Round(totalCartPrice, 2);
        }

        public Item FindItemByName(Item[] cart, string name)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (cart[i].Name == name)
                {
                    return cart[i];
                }
            }
            return null;
        }

    }
}
