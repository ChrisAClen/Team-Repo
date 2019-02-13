using eMNY.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMNY.Code.Helpers
{
  class CardHelper
  {
    private readonly eMNYDbContext _db = new eMNYDbContext();

    public bool SetCard(Card card)
    {
      _db.Cards.Add(card);
      return _db.SaveChanges() > 0;
    }

    public List<Card> GetCards()
    {
      var card = _db.Cards.FromSql("select * from cards");
      var query = (from u in _db.Cards
                   select u).ToList();
      return _db.Cards.Include(m => m.CardNumber).ToList(); //lazy loading
    }
  }
}
