using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
   public class GarageView_BL
    {
       public GarageView_ML GarageEditId;

        public DataTable GetGarageData(GarageView_ML ml)
        {
            try
            {
                return new GarageView_DL().GetGarageData(ml);

            }
            catch
            {
                throw;
            }
        }
        public Boolean RemoveGarage(GarageView_ML ml)
        {
            try
            {
                return new GarageView_DL().RemoveGarage(ml);

            }
            catch
            {
                throw;
            }
        }
        public Boolean AddGarage(GarageView_ML ml)
        {
            return new GarageView_DL().AddGarage(ml);
        }
        public DataTable GetGarageByID(GarageView_ML ml)
        {
            try
            {
                return new GarageView_DL().GetByGarageID(ml);

            }
            catch
            {
                throw;
            }
        }
        public string GetGarageInfo(GarageView_ML ml) 
        {
            try
            {
                return new GarageView_DL().GetGarageInfo(ml);

            }
            catch
            {
                throw;
            }
        } 
        
    }
}
