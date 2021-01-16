using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
  public class ŞəhidRepository:Repository<Şəhid>, IŞəhidRepository
  {
    public ŞəhidRepository(ApplicationDbContext context) : base(context) { }
  }
}
