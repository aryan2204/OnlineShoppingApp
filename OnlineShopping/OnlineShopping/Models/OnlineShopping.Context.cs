﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Online_ShoppingEntities : DbContext
    {
        public Online_ShoppingEntities()
            : base("name=Online_ShoppingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminInfo> AdminInfoes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Retailer> Retailers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
    
        public virtual ObjectResult<CustomerDetails_Result> CustomerDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerDetails_Result>("CustomerDetails");
        }
    
        public virtual int DeleteProductDetails(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProductDetails", idParameter);
        }
    
        public virtual int DeleteProductDetails1(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProductDetails1", idParameter);
        }
    
        public virtual int DeleteRetailer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteRetailer", idParameter);
        }
    
        public virtual int InsertOrders(string order_Status, Nullable<int> customer_Id, Nullable<System.DateTime> order_Date, Nullable<double> total_Amount)
        {
            var order_StatusParameter = order_Status != null ?
                new ObjectParameter("Order_Status", order_Status) :
                new ObjectParameter("Order_Status", typeof(string));
    
            var customer_IdParameter = customer_Id.HasValue ?
                new ObjectParameter("Customer_Id", customer_Id) :
                new ObjectParameter("Customer_Id", typeof(int));
    
            var order_DateParameter = order_Date.HasValue ?
                new ObjectParameter("Order_Date", order_Date) :
                new ObjectParameter("Order_Date", typeof(System.DateTime));
    
            var total_AmountParameter = total_Amount.HasValue ?
                new ObjectParameter("Total_Amount", total_Amount) :
                new ObjectParameter("Total_Amount", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertOrders", order_StatusParameter, customer_IdParameter, order_DateParameter, total_AmountParameter);
        }
    
        public virtual int InsertOrders1(string order_Status, Nullable<int> customer_Id, Nullable<double> total_Amount)
        {
            var order_StatusParameter = order_Status != null ?
                new ObjectParameter("Order_Status", order_Status) :
                new ObjectParameter("Order_Status", typeof(string));
    
            var customer_IdParameter = customer_Id.HasValue ?
                new ObjectParameter("Customer_Id", customer_Id) :
                new ObjectParameter("Customer_Id", typeof(int));
    
            var total_AmountParameter = total_Amount.HasValue ?
                new ObjectParameter("Total_Amount", total_Amount) :
                new ObjectParameter("Total_Amount", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertOrders1", order_StatusParameter, customer_IdParameter, total_AmountParameter);
        }
    
        public virtual int InsertProductDetails1(string id, string name, Nullable<int> quan, Nullable<double> price, string prodDescription, string pic, string col, string size, Nullable<int> retID, string category, string brand)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var quanParameter = quan.HasValue ?
                new ObjectParameter("quan", quan) :
                new ObjectParameter("quan", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var prodDescriptionParameter = prodDescription != null ?
                new ObjectParameter("prodDescription", prodDescription) :
                new ObjectParameter("prodDescription", typeof(string));
    
            var picParameter = pic != null ?
                new ObjectParameter("pic", pic) :
                new ObjectParameter("pic", typeof(string));
    
            var colParameter = col != null ?
                new ObjectParameter("col", col) :
                new ObjectParameter("col", typeof(string));
    
            var sizeParameter = size != null ?
                new ObjectParameter("size", size) :
                new ObjectParameter("size", typeof(string));
    
            var retIDParameter = retID.HasValue ?
                new ObjectParameter("retID", retID) :
                new ObjectParameter("retID", typeof(int));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var brandParameter = brand != null ?
                new ObjectParameter("brand", brand) :
                new ObjectParameter("brand", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProductDetails1", idParameter, nameParameter, quanParameter, priceParameter, prodDescriptionParameter, picParameter, colParameter, sizeParameter, retIDParameter, categoryParameter, brandParameter);
        }
    
        public virtual int InsertRetailer(string name, string email, string num)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var numParameter = num != null ?
                new ObjectParameter("num", num) :
                new ObjectParameter("num", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertRetailer", nameParameter, emailParameter, numParameter);
        }
    
        public virtual ObjectResult<RetailerView_Result> RetailerView()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetailerView_Result>("RetailerView");
        }
    
        public virtual ObjectResult<SearchProductName_Result> SearchProductName(string prodDescription)
        {
            var prodDescriptionParameter = prodDescription != null ?
                new ObjectParameter("prodDescription", prodDescription) :
                new ObjectParameter("prodDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchProductName_Result>("SearchProductName", prodDescriptionParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UpdateCustomerPassword(string pass, string email)
        {
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCustomerPassword", passParameter, emailParameter);
        }
    
        public virtual int UpdateProductDetails1(string id, string name, Nullable<int> quan, Nullable<double> price, string prodDescription, string pic, string col, string size, Nullable<int> retID, string category, string brand)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var quanParameter = quan.HasValue ?
                new ObjectParameter("quan", quan) :
                new ObjectParameter("quan", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var prodDescriptionParameter = prodDescription != null ?
                new ObjectParameter("prodDescription", prodDescription) :
                new ObjectParameter("prodDescription", typeof(string));
    
            var picParameter = pic != null ?
                new ObjectParameter("pic", pic) :
                new ObjectParameter("pic", typeof(string));
    
            var colParameter = col != null ?
                new ObjectParameter("col", col) :
                new ObjectParameter("col", typeof(string));
    
            var sizeParameter = size != null ?
                new ObjectParameter("size", size) :
                new ObjectParameter("size", typeof(string));
    
            var retIDParameter = retID.HasValue ?
                new ObjectParameter("retID", retID) :
                new ObjectParameter("retID", typeof(int));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var brandParameter = brand != null ?
                new ObjectParameter("brand", brand) :
                new ObjectParameter("brand", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateProductDetails1", idParameter, nameParameter, quanParameter, priceParameter, prodDescriptionParameter, picParameter, colParameter, sizeParameter, retIDParameter, categoryParameter, brandParameter);
        }
    
        public virtual ObjectResult<string> LoginRetailer(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoginRetailer", emailParameter);
        }
    }
}
