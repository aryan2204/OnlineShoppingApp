//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OrderDetail_Id { get; set; }
        public Nullable<int> Order_Id { get; set; }
        public string Product_Id { get; set; }
        public int Quantity { get; set; }
        public System.DateTime Order_Date { get; set; }
        public string Order_Status { get; set; }
        public string Ship_To { get; set; }
        public double Total_Amount { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}