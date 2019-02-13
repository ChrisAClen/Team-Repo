using eMNY.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMNY.Code.Helpers
{
  class NameHelper
  {
    private readonly eMNYDbContext _db = new eMNYDbContext();

    public bool SetName(Name name)
    {
      _db.Names.Add(name);
      return _db.SaveChanges() > 0;
    }

    public List<Name> GetNames()
    {
      var name = _db.Names.FromSql("select * from names");
      var query = (from s in _db.Names
                   select s).ToList();
      return _db.Names.Include(m => m.First).ToList(); //lazy loading
    }

  }
}
