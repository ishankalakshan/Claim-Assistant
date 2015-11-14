

using System;
namespace ModelLayer
{
    public class Garage_ML
    {
        public int GarageID { get; set; }
        public string GarageLocation { get; set; }
        public string GarageName { get; set; }
        public string GarageTP { get; set; }
        public string Email { get; set; }

        public Garage_ML()
        {

        }

        public Garage_ML(string id,string location,string name,string tp,string email)
        {
            if (id!=null)
            {
                GarageID = Convert.ToInt32(id);
            }
            if (location!=null)
            {
                GarageLocation = location;
            }
            if (name!=null)
            {
                GarageName = name;
            }
            if (tp!=null)
            {
                GarageTP = tp;
            }
            if (email!=null)
            {
                Email = email;
            }
        }
    }
}
