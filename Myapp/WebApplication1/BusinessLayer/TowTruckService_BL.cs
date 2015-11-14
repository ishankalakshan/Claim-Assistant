using ModelLayer;
using DataLayer;
using System.Data;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class TowTruckService_BL
    {
        public string GetTowTruckServiceInfo(TowTruckService_ML ml)
        {
            try
            {
                return new TowTruckService_DL().GetTowTruckInfo(ml);

            }
            catch
            {
                throw;
            }
        }

        public DataTable GetTowTruckServices(TowTruckService_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Location",ml.location}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetTowTruckServices, DataDic);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public bool AddTowTruckService(TowTruckService_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@TTSName", ml.name},
                    {"@TTSLocation",ml.location},
                    {"@TTSTP",ml.tp},
                    {"@TTSEmail",ml.email}
                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_AddTowTruckService, DataDic);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public bool DeleteTowTruckService(TowTruckService_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.id}
                };
                return new DBAccessController().DeleteRecord(StoredProcedures.sp_RemoveTowTruckService, DataDic);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool UpdateTowTruckService(TowTruckService_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.id},
                    {"@TTSName", ml.name},
                    {"@TTSLocation",ml.location},
                    {"@TTSTP",ml.tp},
                    {"@TTSEmail",ml.email}
                };
                return new DBAccessController().UpdateRecord(StoredProcedures.sp_UpdateTowTruckService, DataDic);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
