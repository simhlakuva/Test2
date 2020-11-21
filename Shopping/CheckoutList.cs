using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class CheckoutList
    {
        private List<Items> ItemsList;

    public CheckoutList()
    {
        ItemsList = new List<Items>();
    }

    public void shoppingCart(Items item)
        {
            ItemsList.Add(item);
        }

public string cartAmount()
{
    StringBuilder builder = new StringBuilder();

            double subtotal = TotalAndSubtotal.Subtotal(ItemsList);
   double vat = TotalAndSubtotal.Vat(ItemsList);

    foreach (Items item in ItemsList)
    {
        builder.AppendLine(item.NameOfItem + "  " + item.Price);
    }


    builder.AppendLine("Subtotal: " + subtotal);
    builder.AppendLine("Including Vat: " + (subtotal + vat));


    return builder.ToString();

}
    }
}
