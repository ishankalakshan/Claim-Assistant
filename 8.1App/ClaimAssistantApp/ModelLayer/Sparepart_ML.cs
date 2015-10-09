using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Sparepart_ML
    {
      public int sparepartId {get;set;}
      public string sparepartName { get; set; }
      public int sparepartCategory { get; set; }
      public string spareManufacturer { get; set; }
      public float spareUnitCost { get; set; }
      public string spareManufacYear { get; set; }
    }
}
