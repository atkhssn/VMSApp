using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using VMS.Domain.Entities;

namespace VMS.Infrastructure.Model
{
    public class VehicleModel
    {
        public long vehicleId { get; set; }
        [Required]
         public String RegNo { get; set; }
        [Required]
        public DateTime RegDate { get; set; }
        [Required]
        public DateTime Reg_Expired { get; set; }
        public long ModelId { get; set; }
        [Required]
        public int Modelyear { get; set; }
        public long VehicleCategoryId { get; set; }
        [Required]
        public int vehicleType { get; set; }
        [Required]
        public int VehicleMode { get; set; }
        public int VehicleCapacityId { get; set; }
        public int VehicleCapacity { get; set; }
        public decimal VehicleMileage { get; set; }
        [Required]
        public int Color { get; set; }
        public long ManufacturedBY { get; set; }
        public string? PhotoUrl { get; set; }
        public IFormFile Photo { get; set; }
        public string? DocumentUrl { get; set; }
        public IFormFile Document { get; set; }
        public long fitness_TaxToken { get; set; }
        public DateTime fitnessExpireDate { get; set; }
        [Required]
        public string Engine { get; set; }
        [Required]
        public string Chassis { get; set; }
    }
}
