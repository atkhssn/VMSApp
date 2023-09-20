using Autofac;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using VMS.Domain.Entities;
using VMS.Infrastructure.Service;
using static VMS.Infrastructure.Utility.EnumCollection;

namespace VMS.Infrastructure.Model
{
    public class DriverModel
    {
        public long DId { get; set; }
        public string DName { get; set; }
        public string Licenceno { get; set; }
        public DateTime LicenceValidation { get; set; }
        public string NIDNumber { get; set; }
        public string DriverShift { get; set; }
        public string DriverType { get; set; }
        public string DriverPhotoUrl { get; set; }
        public IFormFile DriverPhoto { get; set; }
        public string LicenceDocumentUrl { get; set; }
        public IFormFile LicenceDocument { get; set; }
        public string NidDocumentUrl { get; set; }
        public IFormFile NidDocument { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
        public List<DriverModel> Drivers { get; set; }
    }
}

