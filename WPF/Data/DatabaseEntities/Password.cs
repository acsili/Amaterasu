using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amaterasu.Data.DatabaseEntities
{
    [Table("Passwords")]
    public class Password
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string? Value { get; set; }
    }
}
