using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
  public class HomeİnformationRepository : Repository<Homeİnformation>, IHomeİnformationRepository
  {
    public HomeİnformationRepository(ApplicationDbContext context) : base(context) { }
  }
}
