using Amaterasu.Data;
using Amaterasu.Data.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaterasu.Utils;

public class OnlyOnReading : ITeachable
{
    public IEnumerable<Kanji> TeachKanji()
    {
        using var db = new ApplicationContext();

        var kanji = db.Kanji.Select(x => x).ToList();
        //TestCreator.Shuffle();

        for (int i = 0; i < kanji.Count; i++)
        {
            yield return kanji[i];
        }
    }
}

