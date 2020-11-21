using System;
using System.Collections.Generic;
using System.Text;
using Shopping;

namespace Shopping
{
    public class TotalAndSubtotal
    {
        public static double Subtotal(List<Items> ListItems)
        {
            double amount = 0;
            foreach (Items item in ListItems)
            {
                amount += item.Price;
                
            }

            return amount;

        }
        public static double Vat(List<Items> ItemsList)
        {
            double subtotal = Subtotal(ItemsList);

            return subtotal * VAT.vatPercentage;

        }
    }
    class Program
    {
       

        static void Main(string[] args)
        {

             CheckoutList data = new CheckoutList();

            Items Xbox = new Items();
            Xbox.NameOfItem = "Xbox";
            Xbox.Price = 3950.99;
            data.shoppingCart(Xbox);

            Items PS4 = new Items();
            PS4.NameOfItem = "PS4";
            PS4.Price = 5999.49;
            data.shoppingCart(PS4);


            string viewList = data.cartAmount();

            Console.WriteLine(viewList);
        }

    }
}
