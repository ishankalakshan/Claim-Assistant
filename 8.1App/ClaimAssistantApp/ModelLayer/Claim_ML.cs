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
        public string knockedOn;
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
        public double _3rdAmountClaimed;
        public string isDriverOwner;
        public string driverName;
        public string driverLicense;
        public string licenseCat;
        public DateTime licenseExpreDate;

        public string driverNIC;
        public DateTime purchaseDate;
        public string VehicleUsedFor;
        public string rentCompanyName;
        public double rentAmount;
        public List<SparepartPayment_ML> spareParts;
        public double garageCosts;
        public double otherCosts;

        public Claim_ML()
        {

        }

        public Claim_ML(int pclaimId, string plocation, string preason, string pknockedOn, string p_3rdVehicleNo,
                        string p_3rdOwnerName, string p_3rdAddress, string p_3rdContactNo, DateTime p_3rdRenewalDate, string p_3rdSpecialNotes,
                        string p_3rdVictimName, string p_3rdVictimAddress, string p_3rdDamageNature, string p_3rdClaimant, double p_3rdAmountClaimed,
                        string pisDriverOwner, string pdriverName, string pdriverLicense, string plicenseCat, DateTime plicenseExpreDate,
                        string pdriverNIC, DateTime ppurchaseDate, string pVehicleUsedFor, string prentCompanyName, double prentAmount,
                        List<SparepartPayment_ML> pspareParts, string pgarageCosts, string potherCosts)
        {
            try
            {
                if (pclaimId != null)
            {
                claimId = pclaimId;
            }
            if (plocation != null)
            {
                location = plocation;
            }
            if (preason != null)
            {
                reason = preason;
            }
            if (pknockedOn != null)
            {
                knockedOn = pknockedOn;
            }
            if (p_3rdVehicleNo != null)
            {
                _3rdVehicleNo = p_3rdVehicleNo;
            }
            if (p_3rdOwnerName != null)
            {
                _3rdOwnerName = p_3rdOwnerName;
            }
            if (p_3rdAddress != null)
            {
                _3rdAddress=p_3rdAddress;
            }
            if (p_3rdContactNo != null)
            {
                _3rdContactNo=p_3rdContactNo;
            }
            if (p_3rdRenewalDate != null)
            {
                _3rdRenewalDate= Convert.ToDateTime(p_3rdRenewalDate);
            }
            if (p_3rdSpecialNotes != null)
            {
                _3rdSpecialNotes=p_3rdSpecialNotes;
            }
            if (p_3rdVictimName != null)
            {
                _3rdVictimName=p_3rdVictimName;
            }
            if (p_3rdVictimAddress != null)
            {
                _3rdVictimAddress=p_3rdVictimAddress;
            }
            if (p_3rdDamageNature != null)
            {
                _3rdDamageNature=p_3rdDamageNature;
            }
            if (p_3rdClaimant != null)
            {
                _3rdClaimant=p_3rdClaimant;
            }
            if (p_3rdAmountClaimed != null)
            {
                _3rdAmountClaimed = Convert.ToDouble(p_3rdAmountClaimed);
            }
            if (pisDriverOwner != null)
            {
                isDriverOwner = pisDriverOwner;
            }
            if (pdriverName != null)
            {
                driverName = pdriverName;
            }
            if (pdriverLicense != null)
            {
                driverLicense = pdriverLicense;
            }
            if (plicenseCat != null)
            {
                licenseCat = plicenseCat;
            }
            if (plicenseExpreDate != null)
            {
                licenseExpreDate = Convert.ToDateTime(plicenseExpreDate);
            }
            if (pdriverNIC != null)
            {
                driverNIC = pdriverNIC;
            }
            if (ppurchaseDate != null)
            {
                purchaseDate = Convert.ToDateTime(ppurchaseDate);
            }
            if (pVehicleUsedFor != null)
            {
                VehicleUsedFor = pVehicleUsedFor;
            }
            if (prentCompanyName != null)
            {
                rentCompanyName = prentCompanyName;
            }
            if (prentAmount != null)
            {
                rentAmount = Convert.ToDouble(prentAmount);
            }  
            if (pgarageCosts != "")
            {
                garageCosts = Convert.ToDouble(pgarageCosts);
            }
            if (potherCosts != "")
            {
                otherCosts = Convert.ToDouble(potherCosts);
            }
            if (pspareParts != null)
            {
                spareParts = new List<SparepartPayment_ML>();
                foreach (var item in pspareParts)
                {
                    spareParts.Add(item);
                }

                /*for (var i = 0; i < pspareParts.Count; i++)
                {
                    spareParts[i] = pspareParts[i];
                }*/
            }
            }
            catch (Exception)
            {
                
                throw;
            }
        }



    }
}
