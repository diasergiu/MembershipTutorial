using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MembershipOnlineApplication.Entityes
{
    [Table("ProductLinkText")]
    public class ProductLinkText
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProductLinkText { get; set; }
        [MaxLength(25)]
        [Required]
        public string Title { get; set; }
    }
}