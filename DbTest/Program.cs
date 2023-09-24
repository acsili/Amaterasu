using Amaterasu;
using Amaterasu.Data;
using Amaterasu.Data.DatabaseEntities;
using Microsoft.EntityFrameworkCore;
using System.Text;


using (var db = new ApplicationContext())
{
    var w1 = db.Words.FirstOrDefault();
    var w2 = db.Words.AsNoTracking().FirstOrDefault();

    if (w1 != null && w2 != null)
    {

    }
}