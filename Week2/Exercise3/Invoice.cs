using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    public class Invoice
    {
        private string partNumber;

        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        private string partDescription;

        public string PartDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }

        private decimal pricePerItem;
        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value >= 0)
                {
                    pricePerItem = value;
                }

            }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            PricePerItem = pricePerItem;
            Quantity = quantity;
        }

        public Invoice()
        {
        }

        public decimal GetInvoiceAmount()
        {
            decimal amount = Quantity * PricePerItem;
            return amount;
        }
    }
}