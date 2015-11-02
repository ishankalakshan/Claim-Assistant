using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
    public class TowTruckService_BL
    {
        public string GetTowTruckServiceInfo(TowTruckService_ML ml)
        {
            try
            {
                return new TowTruckService_DL().GetTowTruckInfo(ml);

            }
            catch
            {
                throw;
            }
        } 
    }
}
