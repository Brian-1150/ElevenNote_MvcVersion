using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public string CategoryName { get; set; }

        [ForeignKey(nameof(Note))]
        public int NoteId { get; set; }
        public virtual Note Note { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public CategoryColor ColorOfCategory { get; set; }
    }
    public enum CategoryColor
    {
        Red, Orange, Yellow, Green, Blue, Violet
    }
}
