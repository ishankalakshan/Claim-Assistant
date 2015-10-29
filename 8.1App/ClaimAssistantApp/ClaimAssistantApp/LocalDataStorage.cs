using ModelLayer;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace ClaimAssistantApp
{
    public class LocalDataStorage
    {
        public static List<Sparepart_ML> LocalSparepartList = new List<Sparepart_ML>();
        public static List<SparepartCategory_ML> LocalSparepartCatogoryList;
        public static List<SparepartManufacturer_ML> LocalSparepartManufacturerList = new List<SparepartManufacturer_ML>();

    }
}
