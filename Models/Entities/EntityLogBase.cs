using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteApp.Models.Entities
{
    public class EntityLogBase{

        [Required, StringLength(50)]
        public string CreatedUser { get; set; }
        public DateTime CreatedAt { get; set; }

        [StringLength(50)]
        public string ModifiedUser { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
