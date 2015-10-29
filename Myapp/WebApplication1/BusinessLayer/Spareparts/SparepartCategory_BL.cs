using DataLayer;
using ModelLayer.Spareparts;
using System;
using System.Collections.Generic;
using System.Data;
namespace BusinessLayer.Spareparts
{
    public class SparepartCategory_BL
    {
        public List<SparepartCategory_ML> GetSparepartCategories()
        {
            try
            {       
                var SparepartCategoryList = new List<SparepartCategory_ML>();
                var result = new SparePartCategory_DL().GetSparepartCategories();

                foreach (DataRow row in result.Rows)
                {
                    SparepartCategoryList.Add(new SparepartCategory_ML()
                    {
                        spareCategoryId = Convert.ToInt32(row["spareCategoryId"]),
                        spareCategoryName = row["spareCategoryName"].ToString()
                    });
                }       
                return SparepartCategoryList;
            }
            catch
            {
                throw;
            }
        }
    }
}
