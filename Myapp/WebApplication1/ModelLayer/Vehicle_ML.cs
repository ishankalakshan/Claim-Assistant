using System;
using System.Collections.Generic;

namespace ModelLayer
{
    public class Vehicle_ML
    {
     public int VehicleID {get;set;}
     public int VehicleTypeID {get;set;}
	 public int ManufactureId {get;set;}
     public string VehicleTypeName { get; set; }
     public string ManufactureName { get; set; }
	 public string Model {get;set;}
	 public string MakeYear {get;set;}
	 public string FuelType {get;set;}
	 public string EngineCpacity {get;set;}
	 public string seatingCapacity {get;set;}
	 public string CarryingCapacity {get;set;}
	 public float PresentValue {get;set;}
     public float DutyFreeValue { get; set; }

     public Vehicle_ML(){ }

     public Vehicle_ML(string id, string typeid, string manid, string model, string makeyear, 
                       string fueltype, string engincap, string seatcap,string carrycap ,string presentval,string dutyval)
     {
         if (id!=null)
         {
             VehicleID = Convert.ToInt32(id);
         }
         if (typeid != null)
         {
             VehicleTypeID = Convert.ToInt32(typeid);
         }
         if (manid != null)
         {
             ManufactureId = Convert.ToInt32(manid);
         }
         if (model != null)
         {
             Model = model;
         }
         if (makeyear != null)
         {
             MakeYear = makeyear;
         }
         if (fueltype != null)
         {
             FuelType = fueltype;
         }
         if (engincap != null)
         {
             EngineCpacity = engincap;
         }
         if (seatcap != null)
         {
             seatingCapacity = seatcap;
         }
         if (carrycap != null)
         {
             CarryingCapacity = carrycap;
         }
         if (presentval != null)
         {
             PresentValue = Convert.ToSingle(presentval);
         }
         if (dutyval != null)
         {
             DutyFreeValue = Convert.ToSingle(dutyval);
         }
     }

    }
}
