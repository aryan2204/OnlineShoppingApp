using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingAPI.Models
{
    public class Registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Registration()
        //{
        //    this.Orders = new HashSet<Order>();
        //}

        [Key]
        public int Id { get; set; }
        [Required,MinLength(5),MaxLength(20)]
        public string Customer_FirstName { get; set; }
        [Required, MinLength(5), MaxLength(20)]
        public string Customer_LastName { get; set; }
        [Required]
        public string Customer_EMail { get; set; }
        [Phone]
        public string Customer_Mobile_Number { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Customer_Address { get; set; }
    }
}