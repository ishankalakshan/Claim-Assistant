using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class VehicleType_ML
    {
        public int VehicleTypeID { get; set; }
        public string VehicleType { get; set; }

        public VehicleType_ML()
        {

        }
        public VehicleType_ML(string id,string name)
        {
            if (id!=null)
            {
                VehicleTypeID = Convert.ToInt32(id); 
            }
            if (name!=null)
            {
                VehicleType = name;
            }
        }
    }
}
