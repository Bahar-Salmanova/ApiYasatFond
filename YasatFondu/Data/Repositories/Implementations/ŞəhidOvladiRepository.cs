using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
  public class ŞəhidOvladiRepository : Repository<ŞəhidOvladi>, IŞəhidOvladiRepository
  {
    public ŞəhidOvladiRepository(ApplicationDbContext context) : base(context) { }
  }
}
