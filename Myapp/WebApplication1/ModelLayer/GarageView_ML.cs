using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class GarageView_ML
    {
       public int GarageID { get; set; }
        public string GarageLocation { get; set; }
        private string GarageName; 

        public string garageName{
            get {
                return GarageName;
            }
            set {
                GarageName = value;
            }
        }

        public string GarageTP { get; set; }
    }
}
