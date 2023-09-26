using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaterasu.Data.DatabaseEntities
{
    public class Kanji
    {
        public int Id { get; set; }
        [MinLength(1)]
        public string? Value { get; set; }
        [MinLength(1)]
        public string? Translation { get; set; }
        public Reading? Reading { get; set; }
    }
}
