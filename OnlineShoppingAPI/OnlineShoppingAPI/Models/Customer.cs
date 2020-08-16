using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingAPI.Models
{
    public class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public int Id { get; set; }
        public string Customer_EMail { get; set; }
        public string Password { get; set; }
    }
}