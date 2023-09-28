using Amaterasu.Data.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaterasu.Utils;

public interface ITeachable
{
    public IEnumerable<Kanji> TeachKanji();
}

