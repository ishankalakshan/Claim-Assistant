﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Data;
using ModelLayer;
using BusinessLayer;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.IO;

namespace MVCS_WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int AddClaimRequest();

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string Authenticate(string username, string password);

        [OperationContract]
        string GetPolicyInfo(int policy_ID);

        [OperationContract]
        string GetClaimHistory(int policy_ID);

        [OperationContract]
        string GetGarageInfo(string location);

        [OperationContract]
        string GetTowTruckServiceInfo(string location);

        [OperationContract]
        int InsertClaim(string claim);

        [OperationContract]
        string GetSparepartCategories();

        [OperationContract]
        string GetSparepartManufacturers();

        [OperationContract]
        string GetSpareparts(string manufacturer,string catergory);

        [OperationContract]
        bool UploadImages(string image64string,string name,string claimId);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
