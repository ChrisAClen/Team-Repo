using System;
using System.Collections.Generic;
using eMNY.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace eMNY.Code.Helpers
{
  public class TestHelper
  {
    private readonly eMNYDbContext _db = new eMNYDbContext();

    public bool SetCard(Card card)
    {
      DateTime today = DateTime.Now;
      DateTime exp = today.AddYears(4);
      card.ExpirationDate = exp;
      _db.Cards.Add(card);
      return _db.SaveChanges() > 0;
    }

    public List<Card> GetCards()
    {
      var card = _db.Cards.FromSql("select * from cards");
      var query = (from u in card
                   select u).ToList();

      return query.ToList(); //lazy loading
    }
  }
}
