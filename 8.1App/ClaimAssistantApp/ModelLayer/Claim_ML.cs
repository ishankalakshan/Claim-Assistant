using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Claim_ML
    {
        public int claimId;
        public string location;
        public string reason;
        public string knockedON;

        public string _3rdVehicleNo;
        public string _3rdOwnerName;
        public string _3rdAddress;
        public string _3rdContactNo;
        public DateTime _3rdRenewalDate;
        public string _3rdSpecialNotes;

        public string _3rdVictimName;
        public string _3rdVictimAddress;
        public string _3rdDamageNature;
        public string _3rdClaimant;
        public float _3rdAmountClaimed;

        public string isDriverOwner;
        public string driverName;
        public string driverLicense;
        public string licenseCat;
        public DateTime licenseExpreDate;
        public string driverNIC;
        public DateTime purchaseDate;
        public string VehicleUsedFor;
        public string rentCompanyName;
        public float rentAmount;

        public Sparepart_ML [] spareParts;
        public double garageCosts;
        public double otherCosts;


        


    }
}
