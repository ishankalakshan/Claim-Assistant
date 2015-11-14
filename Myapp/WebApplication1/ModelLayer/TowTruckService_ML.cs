using System;

namespace ModelLayer
{
    public class TowTruckService_ML
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string tp { get; set; }
        public string email { get; set; }

        public TowTruckService_ML() { }

        public TowTruckService_ML(int Id, string Name, string Location, string Tp, string Email)
        {
            if (Id != null)
            {
                id = Convert.ToInt32(Id);
            }
            if (Name != null)
            {
                name = Name;
            }
            if (Tp != null)
            {
                tp = Tp;
            }
            if (Name != null)
            {
                location = Location;
            }
            if (Email != null)
            {
                email = Email;
            }
        }

    }
}
