using DataLayer;
using DataLayer.Spareparts;
using ModelLayer.Spareparts;
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer.Spareparts
{
    public class SparepartManufacturer_BL
    {
        public List<SparepartManufacturer_ML> GetSparepartManufacturers()
        { 
            try
            {
                var SparepartManufacturers = new List<SparepartManufacturer_ML>();
                var result = new SparepartManufacturer_DL().GetSparepartManufacturers();

                foreach (DataRow row in result.Rows)
                {
                    SparepartManufacturers.Add(new SparepartManufacturer_ML()
                    {
                        ManufacturerId = Convert.ToInt32(row["ManufacturerId"]),
                        ManufactureName = row["ManufactureName"].ToString()                   
                    });
                }
                return SparepartManufacturers;
            }
            catch
            {
                throw;
            }
        }
    }
}
