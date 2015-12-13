using System;

namespace ModelLayer
{
    public class ClaimRequest_ML
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Status { get; set; }
        public DateTime SubmitTime { get; set; }
        public DateTime RespondTime { get; set; }
        public int RespondEmployeeId { get; set; }

        public ClaimRequest_ML()
        {
        }
        public ClaimRequest_ML(string policyid,string latitude, string longitude,string status,DateTime submittime)
        {
            if (policyid!=null)
            {
                PolicyId = Convert.ToInt32(policyid);
            }
            if (latitude != null)
            {
                Latitude = latitude;
            }
            if (longitude != null)
            {
                Longitude = longitude;
            }
            if (status != null)
            {
                Status = status;
            }
            if (submittime != null)
            {
                SubmitTime = submittime;
            }
        }
    }
}
