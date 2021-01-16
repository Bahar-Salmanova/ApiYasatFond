using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
  public class Şəhid:BaseEntity
  {
    public string Surname { get; set; }
    public string FathersName { get; set; }
    public string Adress { get; set; }
    public string Contact { get; set; }
    public string FinNom { get; set; }
    public string DistrictDied { get; set; }
    public DateTime DateDied { get; set; }
    public string PhotoPassport { get; set; }
    public ICollection<ŞəhidMedal> ŞəhidMedals { get; set; }
    public ICollection<ŞəhidOvladi> ŞəhidOvladis { get; set; }
    public ICollection<Homeİnformation> Homeİnformation { get; set; }
  }
}
