Asset Management System
  
A robust Asset Management System built with ASP.NET Core 8 and Entity Framework Core, designed to manage tangible assets efficiently. The system supports asset tracking, inventory management, maintenance scheduling, depreciation calculation, and user authentication using ASP.NET Core Identity.
Table of Contents

Features
Architecture
Technologies
Getting Started
Prerequisites
Installation
Configuration
Running the Application


Usage
Database Schema
Contributing
License

Features

Asset Management: Track assets by type, inventory batch, and individual items with unique identifiers (e.g., serial numbers).
Inventory Tracking: Manage asset purchases, quantities, and supplier information.
Maintenance Management: Report asset issues and schedule maintenance tasks, with support for single or batch operations.
Depreciation Calculation: Record and track asset depreciation over time.
User Management: Secure user authentication and role-based authorization using ASP.NET Core Identity.
Location Tracking: Assign assets to specific locations (e.g., warehouses, offices).
Reporting: Generate reports for assets, maintenance history, and depreciation (extensible for custom reports).

Architecture
The project follows a modular, Code-First approach using Entity Framework Core. Entities are organized into five modules:

AssetManagement:

AssetType: Defines asset categories.
Asset: Represents asset models or product codes.
InventoryAsset: Tracks asset batches purchased.
AssetItem: Manages individual assets with unique IDs, status, and location.
Location: Stores asset storage locations.


SupplierManagement:

Supplier: Manages supplier details (name, contact, address).


MaintenanceManagement:

AssetIssue: Records reported asset issues.
MaintenanceRecord: Logs maintenance tasks with completion photos.


DepreciationManagement:

DepreciationRecord: Tracks asset depreciation history.


UserManagement:

ApplicationUser: Custom user entity (extends IdentityUser) with UserID (int) for foreign key relationships.
UserRole: Custom role entity (extends IdentityRole) for role-based access (e.g., Admin, Employee, Maintenance).



The database is designed with:

Time-independent tables: AssetType, Location, Supplier, ApplicationUser, UserRole.
Time-dependent tables: Asset, InventoryAsset, AssetItem, AssetIssue, MaintenanceRecord, DepreciationRecord.

Technologies

Backend: ASP.NET Core 8
ORM: Entity Framework Core 8
Authentication: ASP.NET Core Identity
Database: SQL Server (configurable for other providers)
Language: C#
Tools: Visual Studio 2022, .NET CLI

Getting Started
Prerequisites

.NET 8 SDK
SQL Server (or SQL Server Express/LocalDB)
Visual Studio 2022 or VS Code with C# extension
Git for cloning the repository

Installation

Clone the repository:
git clone https://github.com/your-username/asset-management-system.git
cd asset-management-system


Restore dependencies:
dotnet restore


Install EF Core tools (if not already installed):
dotnet tool install --global dotnet-ef



Configuration

Update connection string:Edit appsettings.json to configure your SQL Server connection:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AssetManagementDb;Trusted_Connection=True;"
  }
}


Apply migrations:Generate and apply database migrations to create the schema:
dotnet ef migrations add InitialCreate
dotnet ef database update



Running the Application

Build the project:
dotnet build


Run the application:
dotnet run

The application will start at https://localhost:5001 (or the configured port).

Built with ❤️ by Thangnvhe For issues or suggestions, please open an Issue on GitHub.
