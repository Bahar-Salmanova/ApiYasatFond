using AutoMapper;
using Data.Entities;
using YasatFondu.Resources;

namespace YasatFondu.Mapping
{
  public class ProfileMapping:Profile
  {public ProfileMapping()
    {
      CreateMap<Şəhid, ŞəhidResource>();
    }
  }
}
