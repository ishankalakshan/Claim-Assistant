using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ModelLayer
{
    public class SparepartCategory_ML
    {
        private JToken item;

        public int spareId { get; set; }
        public string spareCatergory { get; set; }

        public SparepartCategory_ML()
        {
        }

        public SparepartCategory_ML(JToken item)
        {
            if (item["spareCategoryId"] !=null)
            {
                spareId = Convert.ToInt32(item["spareCategoryId"]);
            }
            if (item["spareCategoryName"] !=null)
            {
                spareCatergory = item["spareCategoryName"].ToString();
            }
        }
    }   
}
