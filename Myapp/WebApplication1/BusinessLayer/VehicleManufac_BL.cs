using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class VehicleManufac_BL
    {
        public DataTable GetManufacturers(VehicleManufac_ML ml)
        {
            try
            {
                return new VehicleType_DL().GetVehicleList(ml);

            }
            catch
            {
                throw;
            }
        }
    }
}
