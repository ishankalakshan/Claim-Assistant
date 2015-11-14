using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Manufacturer_ML
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public Manufacturer_ML()
        {

        }
        public Manufacturer_ML(string id,string name)
        {
            if (id!=null)
            {
                ManufacturerId = Convert.ToInt32(id);
            }
            if (name!=null)
            {
                ManufacturerName = name;
            }
        }
    }
}
