using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MembershipOnlineApplication.Entityes
{
    [Table("ProtuctType")]
    public class ProductType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdProductType { get; set; }
        [MaxLength(25)]
        [Required]
        public string Title { get; set; }
    }
}