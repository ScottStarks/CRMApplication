using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CRMApplication.Models
{
    [Table("Note")]
    public class NoteViewModel
    {
        [Key]
        public int NoteID { get; set; }

        public int CustomerID { get; set; }

        public string Body { get; set; }

        public string UserCreated { get; set; }
       
    }
}