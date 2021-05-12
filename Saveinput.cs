using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POIS1
{
    public class Saveinput
    {
        bool isValid = true;

        public readonly string help = "Please contact administrator for any inquiry";
        private string Currency;
        private string VendorName;
        private string VendorAddress;
        private string ItemDescription;
        private string ItemName;
        private DateTime Approvedate;
        private string InvoiceStatus;
        private string Totalcurrency;
        private long VendorNumber;
        private double Cost;
        private int Invoicenumber;
        private double Total;
        private int PurchaseOrderNumber;
        private int Quantity;
        private string PurchaseOrderStatus;
        private DateTime DateforPayment;



        public string purchaseOrderStatus
        {
            get { return PurchaseOrderStatus; }
            set { PurchaseOrderStatus = value; }
        } public DateTime dateforpayment
        {
            get { return DateforPayment; }
            set { DateforPayment = value; }
        }
        public string currency
        {
            get { return Currency; }
            set { Currency = value; }
        }

        public string vendorName
        {
            get { return VendorName; }
            set { VendorName = value; }
        }
        public string vendorAddress
        {
            get { return VendorAddress; }
            set { VendorAddress = value; }
        }
        public string itemDescription
        {
            get { return ItemDescription; }
            set { ItemDescription = value; }
        }
        public string itemName
        {
            get { return ItemName; }
            set { ItemName = value; }
        }
        public DateTime approvedate
        {
            get { return Approvedate; }
            set { Approvedate = value; }
        }
        public string invoiceStatus
        {
            get { return InvoiceStatus; }
            set { InvoiceStatus = value; }
        }


        public string totalcurrency
        {
            get { return Totalcurrency; }
            set { Totalcurrency = value; }
        }


        public long vendorNumber
        {
            get { return VendorNumber; }
            set { VendorNumber = value; }
        }
        public double cost
        {
            get { return Cost; }
            set { Cost = value; }
        }
        public int invoicenumber
        {
            get { return Invoicenumber; }
            set { Invoicenumber = value; }
        }
        public double total
        {
            get { return Total; }
            set { Total = value; }
        }
        public int purchaseOrderNumber
        {
            get { return PurchaseOrderNumber; }
            set { PurchaseOrderNumber = value; }
        }
        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
    }
}
