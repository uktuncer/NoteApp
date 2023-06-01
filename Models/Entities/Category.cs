using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteApp.Models.Entities
{
    [Table("Categories")]
    public class Category : EntityLogBase
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(40), Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        [StringLength(160), Display(Name = "Açıklama")]
        public string Description { get; set; }

    }
    [Table("Notes")]
    public class Note : EntityLogBase
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(80), Display(Name = "Başlık")]
        public string Title { get; set; }

        [Required, StringLength(250), Display(Name = "Özet")]
        public string Summary { get; set; }

        [Display(Name = "Detay")]
        public string Detail { get; set; }

        [Display(Name = "Taslak")]
        public bool isDraft { get; set; }

        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
  

    }
}
