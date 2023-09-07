using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaterasu.Data.DatabaseEntities
{
    public class Word
    {
        public int Id { get; set; }      
        public string? WordInJapanese { get; set; }
        public string? Translation { get; set; }
        public int Level { get; set; }

    }
}
