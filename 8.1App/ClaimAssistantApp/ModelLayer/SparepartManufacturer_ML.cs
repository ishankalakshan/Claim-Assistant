using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class SparepartManufacturer_ML
    {
       public int manufacturerId { get; set; }
       public string manufacturerName { get; set; }

       public SparepartManufacturer_ML()
       {                 
       }

       public SparepartManufacturer_ML(JToken item)
       {
           if (item["ManufacturerId"] != null)
           {
               manufacturerId = Convert.ToInt32(item["ManufacturerId"]);
           }
           if (item["ManufactureName"] != null)
           {
               manufacturerName = item["ManufactureName"].ToString();
           }
       }

    }
}
