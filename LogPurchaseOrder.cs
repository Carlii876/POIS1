//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace POIS1
{
    public partial class LogPurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LogPurchaseOrder()
        {
            this.Invoices = new HashSet<Invoice>();
        }

        public int PurchaseOrderId { get; set; }
        public Nullable<int> Vendor_id { get; set; }
        public Nullable<int> Items_id { get; set; }
        public Nullable<int> Item_amount { get; set; }
        public Nullable<int> Status_Id { get; set; }
        public Nullable<int> PurchaseOrderNumber { get; set; }
        public Nullable<System.DateTime> Approval_Date { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<double> Total { get; set; }

        public virtual Currency Currency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual Item Item { get; set; }
        public virtual PurchaseOrderStatu PurchaseOrderStatu { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
