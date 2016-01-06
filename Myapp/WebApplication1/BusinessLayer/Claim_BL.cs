using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Web;

namespace BusinessLayer
{
    public class Claim_BL
    {
        public int createClaimObject(string jstring)
        {
            try
            {
                var sparelist = new List<SparepartPayment_ML>();
                var obj = JObject.Parse(jstring);
                var jArray = JObject.Parse(jstring);
                var sparelistArry = JArray.Parse(jArray["spareParts"].ToString());

                foreach (var item in sparelistArry)
                {
                    sparelist.Add(new SparepartPayment_ML()
                    {
                        sparePartId = (int)item["SparepartId"],
                        sparePartCost = (double)item["SparepartCost"],
                        sparePartQty = (double)item["SparepartQty"]
                    });
                }

                var claimObj = new Claim_ML(Convert.ToInt32(jArray["policyId"].ToString()),
                   jArray["location"].ToString(),
                   jArray["reason"].ToString(),
                   jArray["knockedOn"].ToString(),
                   jArray["_3rdVehicleNo"].ToString(),
                   jArray["_3rdOwnerName"].ToString(),
                   jArray["_3rdAddress"].ToString(),
                   jArray["_3rdContactNo"].ToString(),
                   Convert.ToDateTime(jArray["_3rdRenewalDate"].ToString()),
                   jArray["_3rdSpecialNotes"].ToString(),
                   jArray["_3rdVictimName"].ToString(),
                   jArray["_3rdVictimAddress"].ToString(),
                   jArray["_3rdDamageNature"].ToString(),
                   jArray["_3rdClaimant"].ToString(),
                   Convert.ToDouble(jArray["_3rdAmountClaimed"].ToString()),
                   jArray["isDriverOwner"].ToString(),
                   jArray["driverName"].ToString(),
                   jArray["driverLicense"].ToString(),
                   jArray["licenseCat"].ToString(),
                   Convert.ToDateTime(jArray["licenseExpreDate"].ToString()),
                   jArray["driverNIC"].ToString(),
                   Convert.ToDateTime(jArray["purchaseDate".ToString()]),
                   jArray["VehicleUsedFor"].ToString(),
                   jArray["rentCompanyName"].ToString(),
                   0,
                   sparelist,
                   jArray["garageCosts"].ToString(),
                   jArray["otherCosts"].ToString(),
                   jArray["Deductions"].ToString(),
                   jArray["empid"].ToString()
                   );

                   var claimId = insertClaim(claimObj);

                   return claimId;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public int insertClaim(Claim_ML ml)
        {
            try
            {
                Claim_DL claim = new Claim_DL();
               return claim.insertClaim(ml,claim.InsertClaimPayment(ml),claim.insertDriverDetails(ml),claim.insertThirdPartyDetails(ml));

            }
            catch
            {
                throw;
            }
        }

        public DataTable GetAllClaims(string client)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                     {"@name",client},
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetAllClaims, DataDic);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public DataTable GetClaimById(int claimID)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@ClaimId",claimID}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetClaim, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool UpdateClaimStatus(int claimId,string status)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@ClaimId",claimId},
                    {"@ClaimStatus",status}
                };
                return new DBAccessController().UpdateRecord(StoredProcedures.sp_UpdateClaimStatus, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool SaveImages(string Image64String,string name,string claimId)
        {
            try
            {
                string directory = "E:\\KDU\\Claim.Assisstant\\Myapp\\WebApplication1\\WebApplication1\\ClaimImages\\" + claimId + "\\";
                CreateDirectoryIfNotExists(directory);  
                string dict = directory + name + ".png";                
                System.Drawing.Image image = Base64ToImage(Image64String);
                //System.IO.File.WriteAllText(dict, "Testing valid path & permissions.");
                using (MemoryStream memory = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(dict, FileMode.Create, FileAccess.ReadWrite))
                    {
                        Bitmap im = new Bitmap(image);
                        image.Dispose();
                        image = null;
                        im.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] bytes = memory.ToArray();
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public System.Drawing.Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            ms.Close();
            return image;
        }

        private void CreateDirectoryIfNotExists(string filePath)
        {
            try
            {
                var directory = new FileInfo(filePath).Directory;
                if (directory == null) throw new Exception("Directory could not be determined for the filePath");

                Directory.CreateDirectory(directory.FullName);
            }
            catch (Exception)
            {
                
                throw;
            }           
        }
    }
}
