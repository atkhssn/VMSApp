using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMS.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Licenceno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenceValidation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverShift = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverPhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenceDocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NidDocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DId);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceParts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartsPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaintainceId = table.Column<long>(type: "bigint", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    TripId = table.Column<long>(type: "bigint", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacture",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufactureTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ModelTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManufactureType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufactureType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchant",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsiblePerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufactureType = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TollDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TollName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TollFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TollType = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TollDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TripExpensesId = table.Column<long>(type: "bigint", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TollDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportAgency",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportAgency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripExpenses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fuel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraMileage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RouteMileage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalFuel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverCommission = table.Column<int>(type: "int", nullable: false),
                    HelperCommission = table.Column<int>(type: "int", nullable: false),
                    OvertimeStatus = table.Column<bool>(type: "bit", nullable: false),
                    LaborTips = table.Column<int>(type: "int", nullable: false),
                    TollFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TollName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoadCommission = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripExpenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ManufactureId = table.Column<long>(type: "bigint", nullable: false),
                    ModelId = table.Column<long>(type: "bigint", nullable: false),
                    color = table.Column<int>(type: "int", nullable: false),
                    IsStanderd = table.Column<bool>(type: "bit", nullable: false),
                    ModelYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleMileage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChassisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxToeknFitness = table.Column<long>(type: "bigint", nullable: false),
                    TaxFitnessExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorId = table.Column<long>(type: "bigint", nullable: false),
                    Validation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehicleType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleType", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "MaintenanceParts");

            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "MaintenanceTypes");

            migrationBuilder.DropTable(
                name: "Manufacture");

            migrationBuilder.DropTable(
                name: "ManufactureType");

            migrationBuilder.DropTable(
                name: "Merchant");

            migrationBuilder.DropTable(
                name: "ModelType");

            migrationBuilder.DropTable(
                name: "TollDetails");

            migrationBuilder.DropTable(
                name: "TransportAgency");

            migrationBuilder.DropTable(
                name: "TripExpenses");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "vehicleType");
        }
    }
}
