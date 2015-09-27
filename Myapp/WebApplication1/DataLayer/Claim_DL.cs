using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelLayer;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace DataLayer
{
   public  class Claim_DL : DBConnection
    {
        public bool insertClaim(Claim_ML ml, int paymentId, int driverId, int _3rdpartyId)
       {
           try
           {
               con = new SqlConnection(connectionString);
               con.Open();

               cmd = new SqlCommand("sp_InsertClaim", con) { CommandType = CommandType.StoredProcedure };
               cmd.Parameters.AddWithValue("@policyId", ml.policyId);
               cmd.Parameters.AddWithValue("@reason", ml.reason);
               cmd.Parameters.AddWithValue("@knockedOn", ml.knockedON);
               cmd.Parameters.AddWithValue("@thirdPartyDeatilId", _3rdpartyId);
               cmd.Parameters.AddWithValue("@driverId", driverId);
               cmd.Parameters.AddWithValue("@paymentId", paymentId);
               cmd.Parameters.AddWithValue("@isDriverOwner",ml.isDriverOwner);
               cmd.Parameters.AddWithValue("@vehicleUsage", ml.VehicleUsedFor);
               cmd.Parameters.AddWithValue("@rentCompany", ml.rentCompanyName);
               cmd.Parameters.AddWithValue("@rentAmount", ml.rentAmount);

               return true;
           }
           catch (SqlException ex)
           {
               return false;
           }
           finally
           {
               con.Close();
               con.Dispose();
           }
       }

        public int InsertClaimPayment(Claim_ML ml)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_InsertClaimPayment", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@OtherCosts", ml.otherCosts);
                cmd.Parameters.AddWithValue("@GarageCosts", ml.garageCosts);

                SqlParameter retval = cmd.Parameters.Add("@PaymentId", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int paymentId = (int)cmd.Parameters["@PaymentId"].Value;

                insertSparepartPayment(ml, paymentId);

                return paymentId;
            }
            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public void insertSparepartPayment(Claim_ML ml,int paymentId) {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_InsertSparePartPayment", con) { CommandType = CommandType.StoredProcedure };

                if (ml.spareParts !=null)
                {
                    foreach (var spare in ml.spareParts)
                    {
                        cmd.Parameters.AddWithValue("@PaymentID", paymentId);
                        cmd.Parameters.AddWithValue("@sparePartId", spare.sparePartId);
                        cmd.Parameters.AddWithValue("@sprePartQty", spare.sparePartQty);
                        cmd.Parameters.AddWithValue("@sparePartCost", spare.sparePartCost);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public int insertThirdPartyDetails(Claim_ML ml) {

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_insertThirdPartyDetail", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@_3rdVehicleNo", ml._3rdVehicleNo);
                cmd.Parameters.AddWithValue("@_3rdOwnerName", ml._3rdOwnerName);
                cmd.Parameters.AddWithValue("@_3rdAddress", ml._3rdAddress);
                cmd.Parameters.AddWithValue("@_3rdRenewalDate", ml._3rdRenewalDate);
                cmd.Parameters.AddWithValue("@_3rdSpecialNotes", ml._3rdSpecialNotes);
                cmd.Parameters.AddWithValue("@_3rdVictimName", ml._3rdVictimName);
                cmd.Parameters.AddWithValue("@_3rdVictimAddress", ml._3rdVictimAddress);
                cmd.Parameters.AddWithValue("@_3rdDamageNature", ml._3rdDamageNature);
                cmd.Parameters.AddWithValue("@_3rdClaimant", ml._3rdClaimant);
                cmd.Parameters.AddWithValue("@_3rdAmountClaimed", ml._3rdAmountClaimed);

                SqlParameter retval = cmd.Parameters.Add("@thirdPartyDetailId", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int thirdPartyDetailId = (int)cmd.Parameters["@thirdPartyDetailId"].Value;

                return thirdPartyDetailId;
            }
            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public int insertDriverDetails(Claim_ML ml) {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_insertDriver", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@driverName", ml.driverName);
                cmd.Parameters.AddWithValue("@licenceNo", ml.driverLicense);
                cmd.Parameters.AddWithValue("@ExpirationDate", ml.licenseExpreDate);
                cmd.Parameters.AddWithValue("@Classes", ml.licenseCat);
                cmd.Parameters.AddWithValue("@driverNIC", ml.driverNIC); 

                SqlParameter retval = cmd.Parameters.Add("@driverId", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int driverId = (int)cmd.Parameters["@driverId"].Value;

                return driverId;
            }
            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
