using Data.Repositories.Implementations;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
 public class UnitOfWork : IUnitOfWork
  {
    private readonly ApplicationDbContext _context;
    

    private ŞəhidRepository _şəhidRepository;
    private ŞəhidMedalRepository _şəhidMedalRepository;
    private ŞəhidOvladiRepository _şəhidOvladiRepository;
    private HomeİnformationRepository _homeİnformationRepository;
public UnitOfWork(ApplicationDbContext context)
    {
      this._context = context;
    }
    public IŞəhidRepository Şəhid => _şəhidRepository ??= new ŞəhidRepository(_context);
    public IŞəhidMedalRepository ŞəhidMedal => _şəhidMedalRepository ??= new ŞəhidMedalRepository(_context);
    public IŞəhidOvladiRepository ŞəhidOvladi => _şəhidOvladiRepository ??= new ŞəhidOvladiRepository(_context);
    public IHomeİnformationRepository Homeİnformation => _homeİnformationRepository ??= new HomeİnformationRepository(_context);

    public async Task<int> CommitAsync()
    {
      return await _context.SaveChangesAsync();
    }
  }
}
