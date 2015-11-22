using Newtonsoft.Json.Linq;
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
      public int spareManufacturer { get; set; }
      public float spareUnitCost { get; set; }
      public string spareManufacYear { get; set; }

      public Sparepart_ML()
      {
      }

      public Sparepart_ML(JToken item)
      {
          if (item["sparepartId"] != null)
          {
              sparepartId = Convert.ToInt32(item["sparepartId"]);
          }
          if (item["sparepartName"] != null)
          {
              sparepartName = item["sparepartName"].ToString();
          }
          if (item["spareCategoryId"] != null)
          {
              sparepartCategory = Convert.ToInt32(item["spareCategoryId"]);
          }
          if (item["ManufacturerId"] != null)
          {
              spareManufacturer = Convert.ToInt32(item["ManufacturerId"]);
          }
          if (item["sparepartUnitCost"] != null)
          {
              spareUnitCost = Convert.ToSingle((item["sparepartUnitCost"]));
          }
          if (item["spareparManufacYear"] != null)
          {
              spareManufacYear = item["spareparManufacYear"].ToString();
          }
      }

    }
}
