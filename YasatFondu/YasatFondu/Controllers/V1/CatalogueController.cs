
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using YasatFondu.Resources;

namespace YasatFondu.Controllers.V1
{
  [Route("v1/catalogue")]
  [ApiController]
  public class CatalogueController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CatalogueController(IUnitOfWork unitOfWork,IMapper mapper)
    {
      _unitOfWork = unitOfWork;
      _mapper = mapper;
    }
    [Route("sehids")]
    [HttpGet]
    public async Task<IActionResult> GetSehidler()
  {
      var şehidler = await _unitOfWork.Şəhid.GetAllAsync();
      var ŞəhidResources = _mapper.Map<IEnumerable<Şəhid>, IEnumerable<ŞəhidResource>>(şehidler);
      return Ok(ŞəhidResources);
  }
    [Route("sehidovladi")]
    [HttpGet]
    public async Task<IActionResult> GetSehidOvladi()
    {
      var sehidovladi = await _unitOfWork.ŞəhidOvladi.GetAllAsync();
      var SehidResource= _mapper.Map<IEnumerable<ŞəhidOvladi>, IEnumerable<SehidOvladiResource>>(sehidovladi);
      return Ok(SehidResource);
    }
  }
  
}
