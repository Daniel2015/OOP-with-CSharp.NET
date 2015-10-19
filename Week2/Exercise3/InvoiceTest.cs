using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class InvoiceTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter description of the product: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter partNumber: ");
            string partNumber = Console.ReadLine();

            Console.WriteLine("Enter price for this product: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Invoice myItem = new Invoice(partNumber, description, quantity, price);

            Console.WriteLine("Initial cost of this product is: {0}", myItem.PricePerItem);
            Console.WriteLine("Enter new cost for this product: ");
            myItem.PricePerItem = decimal.Parse(Console.ReadLine());
            Console.WriteLine("New price for this item is: {0}", myItem.PricePerItem);
            Console.WriteLine("The cost amount for {0} with quantity {1} is: {2}", myItem.PartDescription, myItem.Quantity, myItem.GetInvoiceAmount());
        }
    }
}
