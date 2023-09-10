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
        var randomWordList = new List<Word>();

        var words = db.Words.Where(x => x.Level == wordLevel).ToList();

        for (int i = 0; i < 10; i++)
        {
            int r = random.Next(0, words.Count - i);
            randomWordList.Add(words[r]);
            words.RemoveAt(r);
        }

        return randomWordList;
    }

    public List<List<Word>> GetRandomAnswers(List<Word> randomWordList)
    {
        using var db = new ApplicationContext();
        var random = new Random();
        var randomAnswersList = new List<List<Word>>();

        var words = db.Words.Where(x => x.Level == randomWordList[0].Level).ToList();

        for (int i = 0; i < 10; i++)
        {
            
            int r = random.Next(0, words.Count - i);
            randomWordList.Add(words[r]);
            words.RemoveAt(r);
            for (int j = 0; j < 4; j++)
            {

            }
        }

        return randomAnswersList;
    }
}

