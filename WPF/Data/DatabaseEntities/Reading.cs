using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaterasu.Data.DatabaseEntities
{
    public class Reading
    {
        public int Id { get; set; }
        [MinLength(1)]
        public string? On { get; set; }
        [MinLength(1)]
        public string? Kun { get; set; }
        public int KanjiId { get; set; }
        public Kanji? Kanji { get; set; }
    }
}
