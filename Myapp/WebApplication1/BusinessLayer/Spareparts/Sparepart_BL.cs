using DataLayer;
using ModelLayer.Spareparts;
using System;
using System.Collections.Generic;
using System.Data;
using DataLayer.Spareparts;

namespace BusinessLayer.Spareparts
{
    public class Sparepart_BL
    {
        public List<Sparepart_ML> GetSpareparts()
        { 
            try
            {
                var Spareparts = new List<Sparepart_ML>();
                var result = new Sparepart_DL().GetSpareparts();
                foreach (DataRow row in result.Rows)
                {
                    Spareparts.Add(new Sparepart_ML()
                    {
                        sparepartId = Convert.ToInt32(row["sparepartId"]),
                        sparepartCategory = Convert.ToInt32(row["sparepartCategory"]),
                        spareManufacturer = Convert.ToInt32(row["spareManufacturer"]),
                        spareManufacYear = row["spareManufacYear"].ToString(),
                        sparepartModel = row["sparepartName"].ToString(),
                        spareUnitCost = row["spareUnitCost"].ToString()
                    });
                }
                return Spareparts;
            }
            catch
            {
                throw;
            }
        }
    }
}
