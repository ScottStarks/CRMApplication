using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CRMApplication.Models
{
    
    [Table("Customer")]
    public class Customer
    {
        [Key]

        public int CustomerID { get; set; }

        public int AccountID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string emailAddress { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }

}