using System;

namespace Patterns.Facade
{
	/// <summary>
	/// Summary description for CustomerRepresentative.
	/// </summary>
	public class DealerRepresentative
	{
		private VehicleDeliverySystem delivery;
		private VehicleFinanceSystem finance;
		private VehicleInsuranceSystem insurance;
		private VehicleOrderSystem order;
		private VehicleRegistrationSystem registration;
		private VehicleServiceSystem service;

		
		public void GetCarUpdate()
		{
		   this.delivery.GetDeliveryStuff();
		   this.finance.GetVehicleFinanceStuff();
		   this.insurance.GetVehicleInsuranceStuff();
  		 this.order.GetVehicleOrderStuff();
       this.registration.GetVehicleRegistrationStuff();
       this.service.GetVehicleServiceStuff();
		}
		
		public DealerRepresentative()
		{
		  delivery  = new VehicleDeliverySystem();
		  finance  = new VehicleFinanceSystem();
		  insurance  = new VehicleInsuranceSystem();
		  order  = new VehicleOrderSystem();
		  registration  = new VehicleRegistrationSystem();
		  service  = new VehicleServiceSystem();
				
		}

	}
}
