﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace OnlineShopping.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class OnlineDBContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new OnlineDBContainer object using the connection string found in the 'OnlineDBContainer' section of the application configuration file.
        /// </summary>
        public OnlineDBContainer() : base("name=OnlineDBContainer", "OnlineDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new OnlineDBContainer object.
        /// </summary>
        public OnlineDBContainer(string connectionString) : base(connectionString, "OnlineDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new OnlineDBContainer object.
        /// </summary>
        public OnlineDBContainer(EntityConnection connection) : base(connection, "OnlineDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}