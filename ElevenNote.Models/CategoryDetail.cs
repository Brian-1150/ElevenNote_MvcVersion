using ElevenNote.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
  public  class CategoryDetail
    {
        public string CategoryName { get; set; }
        public CategoryColor ColorOfCategory { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
