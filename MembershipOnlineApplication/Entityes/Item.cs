using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MembershipOnlineApplication.Entityes
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdItem { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(2048)]
        public string Descriptions { get; set; }
        [MaxLength(1024)]
        public string Url { get; set; }
        [MaxLength(1024)]
        public string ImageUrl { get; set; }
        [AllowHtml]
        public string HTML { get; set; }
        [DefaultValue(0)]
        public int WaitDays { get; set; }
        public int IsFree { get; set; }
        public string HTMLShort
        {
            get
            { return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50); }
        }

        public int ProductId { get; set; }
        public int ItemTypeId { get; set; }
        public int SectionId { get; set; }
        public int PartId { get; set; }


        [DisplayName("Item Types")]
        public ICollection<ItemType> ItemTypes { get; set; }
        [DisplayName("Sections")]
        public ICollection<Section> Sections { get; set; }
        [DisplayName("Parts")]
        public ICollection<Part> Parts { get; set; }

    }
}