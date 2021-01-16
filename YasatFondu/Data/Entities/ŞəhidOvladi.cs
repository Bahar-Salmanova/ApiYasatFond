using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
  public class ŞəhidOvladi:BaseEntity
  {
    public string Surname { get; set; }
    public string FinCode { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string PassportPhoto { get; set; }
    public int ŞəhidId { get; set; }
    public Şəhid Şəhid { get; set; }
  }
}
