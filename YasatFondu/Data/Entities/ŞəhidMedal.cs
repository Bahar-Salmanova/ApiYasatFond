using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
 public class ŞəhidMedal:BaseEntity
  {
    public int ŞəhidId { get; set; }
    public Şəhid Şəhid { get; set; }
    public DateTime MedalDate { get; set; }

  }
}
