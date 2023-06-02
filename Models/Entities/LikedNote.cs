﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteApp.Models.Entities
{
    [Table("LikedNotes")]
    public class LikedNote
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Kullanıcı")]
        public int UserId { get; set; }
        [Display(Name = "Note")]
        public int NoteId { get; set; }

        public virtual User User { get; set; }
        public virtual Note Note { get; set; }
    }
}
