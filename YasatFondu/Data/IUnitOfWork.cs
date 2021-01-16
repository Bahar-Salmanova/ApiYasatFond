using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
  public interface IUnitOfWork
  {
    IŞəhidRepository Şəhid { get; }
    IŞəhidMedalRepository ŞəhidMedal { get; }
    IŞəhidOvladiRepository ŞəhidOvladi { get; }
    IHomeİnformationRepository Homeİnformation { get; }
  }
}
