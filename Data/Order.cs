//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public Nullable<int> OrderProductID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
    
        public virtual Customers Customer { get; set; }
        public virtual OrderProduct OrderProduct { get; set; }
    }
}
