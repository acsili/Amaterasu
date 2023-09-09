using Amaterasu.Data;
using Amaterasu.Data.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaterasu.Utils;

public class TestCreator
{
    public List<Word> GetRandomWords(string wordLevel)
    {
        using var db = new ApplicationContext();
        var random = new Random();
        var ramdomWordList = new List<Word>();

        var words = db.Words.ToList();

        for (int i = 0; i < 10; i++)
        {
            int r = random.Next(0, words.Count - i);
            ramdomWordList.Add(words[r]);
            words.RemoveAt(r);
        }

        return ramdomWordList;
    }

}

