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
    public class VehicleType_BL
    {
        public DataTable GetVehicleTypes(VehicleType_ML ml)
        {
            try
            {
                return new VehicleType_DL().GetVehicleTypes(ml);

            }
            catch
            {
                throw;
            }
        }
    }
}
