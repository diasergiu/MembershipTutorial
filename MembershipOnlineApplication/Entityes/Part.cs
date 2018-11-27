using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MembershipOnlineApplication.Entityes
{
    [Table("Part")]
    public class Part
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdPart { get; set; }
       [MaxLength(255)]
       [Required]
        public string Title { get; set; }
    }
}