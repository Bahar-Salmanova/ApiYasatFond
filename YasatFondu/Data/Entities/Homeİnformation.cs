using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Entities
{
  public class Homeİnformation
  {
    public int Id { get; set; }
    public bool HomeDocument { get; set; }
    public string PersonPrice { get; set; }
    public int AreaKvMetr { get; set; }
    public int RoomQuantity { get; set; }
    public string RoomPhoto { get; set; }
    //[NotMapped]
    //public IFormFile Upload { get; set; }

    public int ŞəhidId { get; set; }
    public Şəhid Şəhid { get; set; }
  }
}
