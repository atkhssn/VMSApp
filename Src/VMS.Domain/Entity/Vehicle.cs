using VMS.Domain.Entity;

namespace VMS.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public long Id { get; set; }
        public long VehicleTypeId { get; set; }
        public long ManufactureId { get; set; }
        public long ModelId { get; set; } //forenkey, Manufacture By
        public int color { get; set; }
        public bool IsStanderd { get; set; }
        public DateTime ModelYear { get; set; }
        public String VehicleCapacity { get; set; }
        public decimal VehicleMileage { get; set; }
        public string RegNo { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime RegExpiryDate { get; set; }
        public string ChassisNo { get; set; }
        public string EngineNo { get; set; }
        public long TaxToeknFitness { get; set; }
        public DateTime TaxFitnessExpiryDate { get; set; }
        public string ImageUrl { get; set; }
        public string DocumentUrl { get; set; }

        public long VendorId { get; set; }
        public DateTime Validation { get; set; }
    }
}
