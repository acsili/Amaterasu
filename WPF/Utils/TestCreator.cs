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
    public static IEnumerable<Word> GetRandomWords(string wordLevel)
    {
        using var db = new ApplicationContext();
        var random = new Random();

        var words = db.Words.Where(x => x.Level == wordLevel).ToList();

        for (int i = 0; i < 10; i++)
        {
            int r = random.Next(0, words.Count - i);
            yield return words[r];
            words.RemoveAt(r);
        }
    }

    public static IEnumerable<List<Word>> GetRandomAnswers(List<Word> randomWordList)
    {
        using var db = new ApplicationContext();
        var random = new Random();
        var randomAnswersList = new List<List<Word>>();

        var words = db.Words.Where(x => !randomWordList.Contains(x)).ToList();

        for (int i = 0; i < 10; i++)
        {
            var list = new List<Word>();
            int r;
            for (int j = 0; j < 3; j++)
            {
                r = random.Next(0, words.Count);
                list.Add(words[r]);
            }
            list.Add(randomWordList[i]);
            Shuffle(list);
            yield return list;
        }
    }

    private static void Shuffle(List<Word> data)
    {
        var random = new Random();
        for (int i = data.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
            (data[i], data[j]) = (data[j], data[i]);
        }

    }
}

