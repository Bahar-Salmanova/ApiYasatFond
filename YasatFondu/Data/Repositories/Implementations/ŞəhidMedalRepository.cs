using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
  public class ŞəhidMedalRepository : Repository<ŞəhidMedal>, IŞəhidMedalRepository
  {
    public ŞəhidMedalRepository(ApplicationDbContext context) : base(context) { }
  }
}
